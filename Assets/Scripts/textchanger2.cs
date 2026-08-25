using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class textchanger2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float Gasatime;
    public TMP_Text text;
    public bool can;

    int num;

    void Start()
    {
        can = false;
    }

    public void soso()
    {
        text = GameObject.FindGameObjectWithTag("gasa").GetComponent<TMP_Text>();
        can = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (can)
        {
            Gasatime += Time.deltaTime;

        num = (int)Gasatime;

        switch (num)
        {
            case 14:
            {
                text.text = "Cakequake at \nLap-la-lace-snake that brass!";
                break;
            }
            case 19:
            {
                text.text = "시계를 깨트려 지금을 영원히";
                break;
            }
            case 22:
            {
                text.text = "케잌과 배지 건네는 인사과";
                break;
            }
            case 25:
            {
                text.text = "정신 차리니.. (내가 부장이야?)";
                break;
            }
            case 29:
            {
                text.text = "Come on Hey!";
                break;
            }
            case 35:
            {
                text.text = "리버스 : 1999 마도학 사건 대책부 OP \n | Lap-la-lace! Cakequake!";
                break;
            }
        }
    
        }
    }
}