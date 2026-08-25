using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class RhythmJudge : MonoBehaviour
{
    private GameManager GameManager;
    private AudioSource audioSource;
    private ScoreChanger scoreChanger;
    private int _for = 0;
    private List<float> used_note = new List<float>();
    private float judge = 0;
    private float minjudge = 0;
    private int last_for = 0;

    void Awake()
    {
        GameManager = FindObjectOfType<GameManager>();
        audioSource = FindObjectOfType<AudioSource>();
        scoreChanger = FindObjectOfType<ScoreChanger>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            minjudge = 500;
            _for = 0;
            judge = 0;
            while (_for != GameManager.rhythmData.Count)
            {
                judge = Mathf.Abs(GameManager.rhythmData[_for] - audioSource.time);
                if (judge < minjudge)
                {
                    minjudge = judge;
                    last_for = _for;
                }
                _for++;
            }

            if (!used_note.Contains(GameManager.rhythmData[last_for]))
            {
                if (minjudge <= 0.4f)
                {
                    pan.AniPerfect();
                    scoreChanger.Prefect();
                    used_note.Add(GameManager.rhythmData[last_for]);
                }
                else if (minjudge <= 0.5f)
                {
                    pan.AniGood();
                    scoreChanger.Good();
                    used_note.Add(GameManager.rhythmData[last_for]);
                }
            }
            else
            {
                pan.AniMiss();
                scoreChanger.Miss();
            }
        }
    }
    public void Used_Claer()
    {
        used_note.Clear();
    }
}