using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class textchanger4 : MonoBehaviour
{
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
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if (can)
        {
            Gasatime += Time.deltaTime;

            num = (int)Gasatime;


            switch (num)
            {
                case 15:
                    {
                        text.text = "우리들 만나고 헤어지는 모든 일들이";
                        break;
                    }
                case 19:
                    {
                        text.text = "어쩌면 어린애들 놀이 같아";
                        break;
                    }
                case 23:
                    {
                        text.text = "슬픈 동화 속에 구름 타고 멀리 날으는 ";
                        break;
                    }
                case 27:
                    {
                        text.text = "작은 요정들의 슬픈 이야기처럼";
                        break;
                    }
                case 30:
                    {
                        text.text = "그러나 우리들 날지도 못하고 울지만";
                        break;
                    }
                case 35:
                    {
                        text.text = "사랑은 아름다운 꿈결처럼";
                        break;
                    }
                case 38:
                    {
                        text.text = "고운 그대 손을 잡고 밤하늘을 날아서 ";
                        break;
                    }
                case 43:
                    {
                        text.text = "궁전으로 갈 수도 있어";
                        break;
                    }
                case 46:
                    {
                        text.text = "난 오직 그대 사랑하는 마음에";
                        break;
                    }
                case 50:
                    {
                        text.text = "바보같은 꿈 꾸며";
                        break;
                    }
                case 54:
                    {
                        text.text = "이룰 수 없는 저 꿈의 나라로";
                        break;
                    }
                case 58:
                    {
                        text.text = "길을 잃고 헤매고있어";
                        break;
                    }
                case 61:
                    {
                        text.text = "그러나 우리들 날지도 못하고 울지만";
                        break;
                    }
                case 66:
                    {
                        text.text = "사랑은 아름다운 꿈결처럼";
                        break;
                    }
                case 70:
                    {
                        text.text = "고운 그대 손을 잡고 밤하늘을 날아서 ";
                        break;
                    }
                case 74:
                    {
                        text.text = "궁전으로 갈 수도 있어";
                        break;
                    }
                case 78:
                    {
                        text.text = "간주중";
                        break;
                    }
                case 83:
                    {
                        text.text = "난 오직 그대 사랑하는 마음에";
                        break;
                    }
                case 90:
                    {
                        text.text = "밤하늘을 날아서";
                        break;
                    }
                case 108:
                    {
                        text.text = "그대 잠든 모습 바라보다가";
                        break;
                    }
                case 116:
                    {
                        text.text = "입 맞추고 날아가고파";
                        break;
                    }
                case 124:
                    {
                        text.text = "그러나 우리들 날지도 못하고 울지만";
                        break;
                    }
                case 128:
                    {
                        text.text = "사랑은 아름다운 꿈결처럼";
                        break;
                    }
                case 131:
                    {
                        text.text = "고운 그대 손을 잡고 밤하늘을 날아서 ";
                        break;
                    }
                case 136:
                    {
                        text.text = "궁전으로 갈 수도 있어";
                        break;
                    }
                case 139:
                    {
                        text.text = "난 오직 그대 사랑하는 마음에";
                        break;
                    }
                case 143:
                    {
                        text.text = "밤하늘을 날아서";
                        break;
                    }
                case 147:
                    {
                        text.text = "그대 잠든 모습 바라보다가";
                        break;
                    }
                case 151:
                    {
                        text.text = "입 맞추고 날아가고파";
                        break;
                    }
                case 155:
                    {
                        text.text = "그러나 우리들 날지도 못하고 울지만";
                        break;
                    }
                case 159:
                    {
                        text.text = "사랑은 아름다운 꿈결처럼";
                        break;
                    }
                case 162:
                    {
                        text.text = "고운 그대 손을 잡고 밤하늘을 날아서";
                        break;
                    }
                case 167:
                    {
                        text.text = "꿈빛 궁전으로 갈 수도 있어";
                        break;
                    }
            }
            }
    }
}
