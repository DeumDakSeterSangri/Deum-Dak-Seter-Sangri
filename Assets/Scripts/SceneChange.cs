using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private GameManager gameManager;
    private RhythmJudge rhythmJudge;
    private ScoreChanger _ScoreChanger;
    private AudioManage _AudioManage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        _ScoreChanger = FindObjectOfType<ScoreChanger>();
        rhythmJudge = FindObjectOfType<RhythmJudge>();
        _AudioManage = FindObjectOfType<AudioManage>();
        
    }
    public void chage1()
    {
        gameManager.Noteposition1();
        _ScoreChanger.C1();
        SceneManager.LoadScene("1");
        _AudioManage.S123 = 1;
        gameManager.HData();
    }
    
    public void chage2()
    {
        gameManager.Noteposition2();
        SceneManager.LoadScene("2");
        _ScoreChanger.C2();
        _AudioManage.S123 = 2;
        gameManager.MData();
        
    }

    public void chage3()
    {
        SceneManager.LoadScene("3");
        _AudioManage.S123 = 3;
        gameManager.DData();
        gameManager.time = 0;
    }
    
    public void chage4()
    {
        SceneManager.LoadScene("4");
        _AudioManage.S123 = 4;
        gameManager.DData();
        gameManager.time = 0;
    }

    public void chagemain()
    {
        SceneManager.LoadScene("main");
        rhythmJudge.Used_Claer();
        GameManager.rhythmData.Clear();
        gameManager.n = 0;
        _AudioManage.S123 = 0;
        _AudioManage.s5 = false;
    }

    public void chageaudio(){
        SceneManager.LoadScene("오디오 조정");
        rhythmJudge.Used_Claer();
        GameManager.rhythmData.Clear();
        gameManager.n = 0;
    }

    public void HGood()
    {
        SceneManager.LoadScene("1Good");
    }
    public void HNormal()
    {
        SceneManager.LoadScene("1Normal");
    }
    public void HBad()
    {
        SceneManager.LoadScene("1Bad");
    }
    
    public void MGood()
    {
        SceneManager.LoadScene("2Good");
    }
    public void MNormal()
    {
        SceneManager.LoadScene("2Normal");
    }
    public void MBad()
    {
        SceneManager.LoadScene("2Bad");
    }
    
    public void LGood()
    {
        SceneManager.LoadScene("3Good");
    }
    public void LNormal()
    {
        SceneManager.LoadScene("3Normal");
    }
    public void LBad()
    {
        SceneManager.LoadScene("3Bad");
    }
}
