using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class textchanger1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float Gasatime;
    public TMP_Text text;
    public TMP_Text na;
    public bool can;

    int num;

    void Awake()    
    {
        can = false;
    }

    public void soso()
    {
        text = GameObject.FindGameObjectWithTag("gasa").GetComponent<TMP_Text>();
        na = GameObject.FindGameObjectWithTag("teto").GetComponent<TMP_Text>();
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
            case 0:
                {
                    text.text = "저기 말야, 정말! 안 듣고 있지?";
                    break;
                }
            case 2:
                {
                    text.text = "아까부터 하는 얘기";
                    break;
                }
            case 4:
                {
                    text.text = "건성 대답에, 영혼 빠진 대답에";
                    break;
                }
            case 6:
                {
                    text.text = "정말 무정하네";
                    break;
                }
            case 7:
                {
                    text.text = "시선이나 피하고, 지금 한창 이벤트 중인데";
                    break;
                }
            case 11:
                {
                    text.text = "넋이 나가서, 네 마음은";
                    break;
                }
            case 13:
                {
                    text.text = "지금 여기 없는 거지?";
                    break;
                }
            case 14:
                {
                    text.text = "또 소훌하기 뿐이고,";
                    break;
                }
            case 17:
                {
                    text.text = "흥미 없다는 표정뿐이고";
                    break;
                }
            case 18:
                {
                    text.text = "그치만, 웃을 수 있으면서!";
                    break;
                }
            case 20:
                {
                    text.text = "거기에 휘청휘청 해버리는데!";
                    break;
                }
            case 22:
                {
                    text.text = "건성인 너에게는";
                    break;
                }
            case 25:
                {
                    text.text = "퀘스트를 내릴게";
                    break;
                }
            case 29:
                {
                    text.text = "나를 좋아하지?";
                    break;
                }
            case 30:
                {
                    text.text = "뭐, 그렇지? 귀엽지?";
                    break;
                }
            case 32:
                {
                    text.text = "그러니까 좀 더 오냐오냐해줘!";
                    break;
                }
            case 35:
                {
                    text.text = "그러니까 좀 더 오냐오냐해줘! \n >엄청엄청 귀여워!";
                    break;
                }
            case 36:
                {
                    text.text = "나, 만만치 않지? 그래도 어쩔 수 없지?";
                    break;
                }
            case 38:
                {
                    text.text = "그치만 말야, 내가";
                    break;
                }
            case 40:
                {
                    text.text = "당신의 진 히로인이라구!";
                    break;
                }
            case 43:
                {
                    text.text = "열심히 꾸몄지? 기합 넣어서 왔지?";
                    break;
                }
            case 47:
                {
                    text.text = "그러니까 전력으로 예뻐♡ 해 줘!";
                    break;
                }
            case 49:
                {
                    text.text = "그러니까 전력으로 예뻐♡ 해 줘! \n > 에, 맨얼굴로 괜찮지 않아?";
                    break;
                }
            case 51:
                {
                    text.text = "아, 정말 그게 아니야!";
                    break;
                }
            case 52:
                {
                    text.text = "이제 됐어! 제대로 눈치챌 때까지";
                    break;
                }
            case 54:
                {
                    text.text = "계속 계속 RE퀘스트라구!";
                    break;
                }
            case 65:
                {
                    text.text = "저기 저기, 유죄잖아? 너의 나쁜 점";
                    break;
                }
            case 68:
                {
                    text.text = "벌벌 떨기나 하고, 입 꾹 다물기나 하고";
                    break;
                }
            case 70:
                {
                    text.text = "흥, 반성은 좀 했으려나?";
                    break;
                }
            case 73:
                {
                    text.text = "어쩔까나, 용서해 줄까나?";
                    break;
                }
            case 75:
                {
                    text.text = "옆에 있는 너, 또 안 듣고 있지?";
                    break;
                }
            case 78:
                {
                    text.text = "이젠 한계야!";
                    break;
                }
            case 79:
                {
                    text.text = "나, 화났잖아?";
                    break;
                }
            case 81:
                {
                    text.text = "알고 있지? 싫지?";
                    break;
                }
            case 82:
                {
                    text.text = "그러니까 한눈팔지 말라구!";
                    break;
                }
            case 85:
                {
                    text.text = "그러니까 한눈팔지 말라구! \n >언제라도 좋아해!";
                    break;
                }
            case 86:
                {
                    text.text = "어차피, 내 손바닥 안이지? 어쩔 수 없지?";
                    break;
                }
            case 89:
                {
                    text.text = "그치만 말야, 내가";
                    break;
                }
            case 90:
                {
                    text.text = "당신의 진 히로인이라구!";
                    break;
                }
            case 93:
                {
                    text.text = "열심히 꾸몄지? 준비하는 데 얼마나 걸렸게?";
                    break;
                }
            case 96:
                {
                    text.text = "전부, 너를 위해서란 말이야";
                    break;
                }
            case 99:
                {
                    text.text = "전부, 너를 위해서란 말이야 \n >에, 평범한 걸로 괜찮지 않아?";
                    break;
                }
            case 100:
                {
                    text.text = "아, 정말 그게 아니야!";
                    break;
                }
            case 102:
                {
                    text.text = "이제 됐어! 제대로 눈치챌 때까지";
                    break;
                }
            case 105:
                {
                    text.text = "계속 계속 RE퀘스트라구!";
                    break;
                }
            case 109:
                {
                    text.text = "노래 : 히로인RE♡퀘스트 \n feat. 카사네 테토(아티스트 : 삼사)";
                    break;
                }
            case 114:
                {
                    text.text = "출처 : https://youtu.be/VXA0PEjkIGU?si=a0n9Svaish7JzOId";
                    break;
                }
            case 118:
                {
                    text.text = "히로인RE♡퀘스트를 영업하기위한 게임입니다!";
                    break;
                }
            case 122:
                {
                    text.text = "언제나 둔하고, 고집쟁이에";
                    break;
                }
            case 126:
                {
                    text.text = "너는 정말로 바보구나";
                    break;
                }
            case 129:
                {
                    text.text = "하지만 갑자기 미소를 보여주는";
                    break;
                }
            case 133:
                {
                    text.text = "네가..";
                    break;
                }
            case 134:
                {
                    text.text = "네가...";
                    break;
                }
            case 135:
                {
                    text.text = "그거, 반칙 아니야?!";
                    break;
                }
            case 137:
                {
                    text.text = "나, 성가시지? 그렇잖아? 응, 그렇지..";
                    break;
                }
            case 140:
                {
                    text.text = "그런 것쯤은 알고 있어";
                    break;
                }
            case 143:
                {
                    text.text = "하지만 어쩔 수 없잖아? 너에게 안기고 싶으니까";
                    break;
                }
            case 147:
                {
                    text.text = "아, 정말 어쩔 수 없어!";
                    break;
                }
            case 151:
                {
                    text.text = "하지만 좋아하지?";
                    break;
                }
            case 152:
                {
                    text.text = "뭐, 그렇지? 귀엽지?";
                    break;
                }
            case 154:
                {
                    text.text = "그러니까 좀 더 오냐오냐해줘!";
                    break;
                }
            case 156:
                {
                    text.text = "그러니까 좀 더 오냐오냐해줘! \n >엄청엄청 귀여워!";
                    break;
                }
            case 158:
                {
                    text.text = "나, 만만치 않지? 그래도 어쩔 수 없지?";
                    break;
                }
            case 160:
                {
                    text.text = "그치만, 내가";
                    break;
                }
            case 162:
                {
                    text.text = "당신의 진 히로인이라구!";
                    break;
                }
            case 165:
                {
                    na.text = "레이";
                    text.text = "나, 풋내기에다가, 쑥맥이고";
                    break;
                }
            case 167:
                {
                    text.text = "심술쟁이인 너도";
                    break;
                }
            case 169:
                {
                    text.text = "꽤 많이 좋아하지만";
                    break;
                }
            case 171:
                {
                    text.text = "꽤 많이 좋아하지만 \n >그런 점 귀여워!";
                    break;
                }
            case 172:
                {
                    text.text = "쑥스러워 숨기는 것조차,";
                    break;
                }
            case 174:
                {
                    text.text = "완전히 정복할 때까지";
                    break;
                }
            case 176:
                {
                    na.text = "테토";
                    text.text = "계속 계속 RE퀘스트라구!";
                    break;
                }
            case 179:
                {
                    na.text = "레이";
                    text.text = "그러면 계속 계속 리플레이할게";
                    break;
                }
        }
    
        }
    }
}