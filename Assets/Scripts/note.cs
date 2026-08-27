using System;
using UnityEngine;
using System.Collections;

public class note : MonoBehaviour
{
    public float speed = 7.0f;
    public float destroyX = -6.2f;
    private ScoreChanger scoreChanger;
    private AudioManage _AudioManage;

    void Start()
    {
        scoreChanger = FindObjectOfType<ScoreChanger>();
        _AudioManage = FindObjectOfType<AudioManage>();
    }
    void FixedUpdate()
    {
        if (transform.position.x <= destroyX)
        {
            if (_AudioManage.S123 == 1)
            {
                transform.position = new Vector3(-6.2f, 1.9f, 1);
            }
            if (_AudioManage.S123 == 2)
            {
                transform.position = new Vector3(-6.2f, 2.5f, 1);
            }
            if (_AudioManage.S123 == 3)
            {
                transform.position = new Vector3(-6.2f, 2.5f, 1);
            }
            if (_AudioManage.S123 == 4)
            {
                transform.position = new Vector3(-6.2f, 2.5f, 1);
            }
            StartCoroutine(Destroy());
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(0.1f);
        scoreChanger.Miss();
        Destroy(gameObject);
    }
}
