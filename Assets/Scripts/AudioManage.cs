using System.Threading;
using UnityEngine;
using System.Collections;


public class AudioManage : MonoBehaviour
{
    public int S123 = 0;
    private textchanger1 textchanger1;
    private  textchanger2 textchanger2;
    private  textchanger3 textchanger3;
    private GameManager gameManager;
    private ScoreChanger _ScoreChanger;
    public AudioSource audioSource;
    
    public bool s5;
    private SceneChange SceneChage;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        textchanger1 = FindObjectOfType<textchanger1>();
        textchanger2 = FindObjectOfType<textchanger2>();
        textchanger3 = FindObjectOfType<textchanger3>();
        audioSource = GetComponent<AudioSource>();
        SceneChage = FindObjectOfType<SceneChange>();
        _ScoreChanger = FindObjectOfType<ScoreChanger>();
        s5 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (s5 == false && gameManager.time >= 5.0f)
        {
            if (S123 == 1)
            {
                textchanger1.soso();    
            }
            else if (S123 == 2)
            {
                textchanger2.soso();
            }
            else if (S123 == 3)
            {
                textchanger3.soso();
            }
            s5 = true;
            audioSource.Play();
        }
    }

    void FixedUpdate()
    {
        if (s5 == true && audioSource.isPlaying == false)
        {
            StartCoroutine(Gomain());
        }
    }


    IEnumerator Gomain()
    {
        yield return new WaitForSeconds(3f);
        if (S123 == 1)
        {
            if (_ScoreChanger.score >= 1000)
            {
                SceneChage.HGood();
            }
            else if (_ScoreChanger.score >= 500)
            {
                SceneChage.HNormal();
            }
            else
            {
                SceneChage.HBad();
            }
        }
        if (S123 == 2)
        {
            if (_ScoreChanger.score >= 1000)
            {
                SceneChage.MGood();
            }
            else if (_ScoreChanger.score >= 500)
            {
                SceneChage.MNormal();
            }
            else
            {
                SceneChage.MBad();
            }
        }
        if (S123 == 3)
        {
            if (_ScoreChanger.score >= 1000)
            {
                SceneChage.LGood();
            }
            else if (_ScoreChanger.score >= 500)
            {
                SceneChage.LNormal();
            }
            else
            {
                SceneChage.LBad();
            }
        }
    }
}
