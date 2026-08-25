using System;
using UnityEngine;

public class audiotimeing : MonoBehaviour
{
    public GameObject audionote;
    Vector3 offset = new Vector3(10, 0, 1);
    private float time2;
    public float time ;
    //반복 횟수
    private int j;
    GameManager _gameManager;

    private void Start()
    {
        j = 0;
        _gameManager = FindObjectOfType<GameManager>();
    }
    
    void FixedUpdate()
    {
        time += Time.deltaTime;
        time2 += Time.deltaTime;
        if (time - j == 0)
        {
            Instantiate(audionote, offset, Quaternion.identity);
            j += 1;
        }
    }

}
