using TMPro;
using UnityEngine;

public class ScoreChanger : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoretext;
    private GameObject textObject;
    private AudioManage _AudioManage;

    void Start()
    {
        _AudioManage = FindObjectOfType<AudioManage>();
    }

    public void GasaGo()
    {
        textObject = GameObject.FindGameObjectWithTag("Text");

        if (textObject == null)
        {
            Debug.LogError("텍스트 못찾음");
        }
        else
        {
            scoretext = textObject.GetComponent<TMP_Text>();
        }
    }

    void Update()
    {
        if (_AudioManage.S123 != 0)
        {
            scoretext.text = score.ToString();
        }
    }

    public void C1()
    {
        score = 50;
    }

    public void C2()
    {
        score = 1999;
    }

    public void C3()
    {
        score = 50;
    }

    public void Good()
    {
        if (_AudioManage.S123 == 1)
        {
            score += 6;
        }
    }

    public void Miss()
    {
        score -= 5;
    }

    public void Prefect()
    {
        score += 10;
    }
}