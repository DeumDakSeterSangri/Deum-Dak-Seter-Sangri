using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class RhythmNoteRecorder : MonoBehaviour
{
    
    [Header("오디오 설정")]
    public AudioSource audioSource;

    [Tooltip("게임 시작과 동시에 음악을 재생할지 여부")]
    public bool playOnStart = false;

    [Header("노트 기록 설정")]
    [Tooltip("노트 입력 키")]
    public KeyCode recordKey = KeyCode.Space;

    [Tooltip("마지막 기록 삭제 키")]
    public KeyCode undoKey = KeyCode.Backspace;

    [Tooltip("JSON 저장 키")]
    public KeyCode saveKey = KeyCode.S;

    [Tooltip("기록을 전부 초기화하는 키")]
    public KeyCode clearKey = KeyCode.Delete;

    [Header("저장 설정")]
    [Tooltip("저장될 JSON 파일 이름")]
    public string fileName = "RhythmNoteData.json";

    [Header("현재 상태")]
    [SerializeField] private float currentMusicTime;
    [SerializeField] private List<NoteData> recordedNotes = new List<NoteData>();

    private bool isRecording;

    public float CurrentMusicTime => currentMusicTime;
    public IReadOnlyList<NoteData> RecordedNotes => recordedNotes;

    private void Start()
    {
        if (audioSource == null)
        {
            Debug.LogError("RhythmNoteRecorder에 AudioSource가 연결되지 않았습니다.");
            enabled = false;
            return;
        }

        if (playOnStart)
        {
            StartCoroutine(PlaySound());
        }
    }
    IEnumerator PlaySound()
    {
        yield return new WaitForSeconds(5f);
        audioSource.Play();
        StartRecording();
    }
    private void Update()
    {
        UpdateCurrentTime();

        if (!isRecording)
        {
            return;
        }

        if (Input.GetKeyDown(recordKey))
        {
            RecordNote();
        }

        if (Input.GetKeyDown(undoKey))
        {
            UndoLastNote();
        }

        if (Input.GetKeyDown(saveKey))
        {
            SaveNoteData();
        }

        if (Input.GetKeyDown(clearKey))
        {
            ClearAllNotes();
        }
    }

    private void UpdateCurrentTime()
    {
        if (audioSource == null)
        {
            currentMusicTime = 0f;
            return;
        }

        currentMusicTime = audioSource.time;
    }

    /// <summary>
    /// 음악을 처음부터 재생하고 노트 기록을 시작합니다.
    /// </summary>
    public void StartRecording()
    {
        if (audioSource == null || audioSource.clip == null)
        {
            Debug.LogError("AudioSource 또는 AudioClip이 연결되지 않았습니다.");
            return;
        }

        recordedNotes.Clear();

        audioSource.Stop();
        audioSource.time = 0f;
        audioSource.Play();

        isRecording = true;

        Debug.Log("노트 기록을 시작합니다.");
    }

    /// <summary>
    /// 현재 음악 시간에 노트를 기록합니다.
    /// </summary>
    public void RecordNote()
    {
        if (audioSource == null || !audioSource.isPlaying)
        {
            return;
        }

        float noteTime = audioSource.time;

        NoteData note = new NoteData
        {
            noteIndex = recordedNotes.Count,
            time = noteTime,
            noteType = NoteType.Normal,
            lane = 0
        };

        recordedNotes.Add(note);

        Debug.Log(
            $"노트 기록 완료 | 번호: {note.noteIndex}, 시간: {note.time:F3}초"
        );
    }

    /// <summary>
    /// 마지막으로 기록한 노트를 삭제합니다.
    /// </summary>
    public void UndoLastNote()
    {
        if (recordedNotes.Count == 0)
        {
            Debug.Log("삭제할 노트가 없습니다.");
            return;
        }

        int lastIndex = recordedNotes.Count - 1;
        NoteData removedNote = recordedNotes[lastIndex];

        recordedNotes.RemoveAt(lastIndex);
        RefreshNoteIndexes();

        Debug.Log($"마지막 노트 삭제 | 시간: {removedNote.time:F3}초");
    }

    /// <summary>
    /// 기록된 모든 노트를 삭제합니다.
    /// </summary>
    public void ClearAllNotes()
    {
        recordedNotes.Clear();

        Debug.Log("기록된 노트를 모두 삭제했습니다.");
    }

    /// <summary>
    /// 기록된 데이터를 JSON 파일로 저장합니다.
    /// </summary>
    public void SaveNoteData()
    {
        RhythmChartData chartData = new RhythmChartData
        {
            musicName = GetMusicName(),
            musicLength = GetMusicLength(),
            bpm = 0f,
            notes = new List<NoteData>(recordedNotes)
        };

        string json = JsonUtility.ToJson(chartData, true);
        string savePath = GetSavePath();

        try
        {
            File.WriteAllText(savePath, json);

            Debug.Log(
                $"노트 데이터 저장 완료\n" +
                $"노트 개수: {recordedNotes.Count}\n" +
                $"저장 위치: {savePath}"
            );
        }
        catch (Exception exception)
        {
            Debug.LogError($"노트 데이터 저장 실패: {exception.Message}");
        }
    }

    /// <summary>
    /// 저장된 JSON 파일을 불러옵니다.
    /// </summary>
    public void LoadNoteData()
    {
        string savePath = GetSavePath();

        if (!File.Exists(savePath))
        {
            Debug.LogWarning($"저장 파일이 없습니다: {savePath}");
            return;
        }

        try
        {
            string json = File.ReadAllText(savePath);
            RhythmChartData chartData =
                JsonUtility.FromJson<RhythmChartData>(json);

            if (chartData == null || chartData.notes == null)
            {
                Debug.LogError("JSON 데이터 형식이 올바르지 않습니다.");
                return;
            }

            recordedNotes = chartData.notes;
            RefreshNoteIndexes();

            Debug.Log(
                $"노트 데이터 불러오기 완료 | 노트 개수: {recordedNotes.Count}"
            );
        }
        catch (Exception exception)
        {
            Debug.LogError($"노트 데이터 불러오기 실패: {exception.Message}");
        }
    }

    /// <summary>
    /// 음악을 일시 정지하거나 다시 재생합니다.
    /// </summary>
    public void TogglePause()
    {
        if (audioSource == null)
        {
            return;
        }

        if (audioSource.isPlaying)
        {
            audioSource.Pause();
            isRecording = false;

            Debug.Log("음악 및 기록 일시 정지");
        }
        else
        {
            audioSource.UnPause();
            isRecording = true;

            Debug.Log("음악 및 기록 다시 시작");
        }
    }

    /// <summary>
    /// 원하는 시간으로 음악 위치를 이동합니다.
    /// </summary>
    public void SetMusicTime(float time)
    {
        if (audioSource == null || audioSource.clip == null)
        {
            return;
        }

        float clampedTime = Mathf.Clamp(
            time,
            0f,
            audioSource.clip.length
        );

        audioSource.time = clampedTime;
        currentMusicTime = clampedTime;
    }

    private void RefreshNoteIndexes()
    {
        for (int i = 0; i < recordedNotes.Count; i++)
        {
            recordedNotes[i].noteIndex = i;
        }
    }

    private string GetMusicName()
    {
        if (audioSource != null && audioSource.clip != null)
        {
            return audioSource.clip.name;
        }

        return "Unknown Music";
    }

    private float GetMusicLength()
    {
        if (audioSource != null && audioSource.clip != null)
        {
            return audioSource.clip.length;
        }

        return 0f;
    }

    private string GetSavePath()
    {
        return Path.Combine(Application.persistentDataPath, fileName);
    }
}

[Serializable]
public class RhythmChartData
{
    public string musicName;
    public float musicLength;
    public float bpm;
    public List<NoteData> notes = new List<NoteData>();
}

[Serializable]
public class NoteData
{
    public int noteIndex;

    // 음악 시작 후 노트가 판정선에 도착해야 하는 시간
    public float time;

    // 여러 레인을 사용할 때 사용할 값
    public int lane;

    // 일반 노트, 롱 노트 등을 구분
    public NoteType noteType;
}

public enum NoteType
{
    Normal,
    Long,
    Special
}