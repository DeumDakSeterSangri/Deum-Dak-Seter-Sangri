using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class textchanger3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float time;
    public TMP_Text text;
    public bool can;
    int num;
    void Start()
    {
        can = false;
    }

    public void soso()
    {
        can = true;
    }



    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        num = (int)time;

        switch (num)
        {
            case 1:
                {
                    text.text = "Open the curtains";
                    break;
                }
            case 4:
                {
                    text.text = "Lights on";
                    break;
                }
            case 7:
                {
                    text.text = "Don't miss a moment ";
                    break;
                }
            case 8:
                {
                    text.text = "of this experiment";
                    break;
                }
            case 10:
                {
                    text.text = "Oh, the book is strange";
                    break;
                }
            case 12:
                {
                    text.text = "Like clockwork orange";
                    break;
                }
            case 14:
                {
                    text.text = "Keep your eyes buttered till the end";
                    break;
                }
            case 18:
                {
                    text.text = "";
                    break;
                }
            case 20:
                {
                    text.text = "Which \'you\' are you going to be?";
                    break;
                }
            case 24:
                {
                    text.text = "Hmm";
                    break;
                }
            case 25:
                {
                    text.text = "Inside the mirror do you see";
                    break;
                }
            case 28:
                {
                    text.text = " ";
                    break;
                }
            case 29:
                {
                    text.text = "Someone else in that body?";
                    break;
                }
            case 32:
                {
                    text.text = "Dance for me";
                    break;
                }
            case 33:
                {
                    text.text = "One and, Two and, Three and";
                    break;
                }
            case 35:
                {
                    text.text = "Turn around";
                    break;
                }
            case 36:
                {
                    text.text = "Sit like a doggy";
                    break;
                }
            case 38:
                {
                    text.text = "Till I finish my read";
                    break;
                }
            case 39:
                {
                    text.text = "Cut it off, cut down your loss";
                    break;
                }
            case 41:
                {
                    text.text = "All that stubborn loyalty is gonna get you killed";
                    break;
                }
            case 47:
                {
                    text.text = "In a world built on\n convenient theories";
                    break;
                }
            case 48:
                {
                    text.text = "For the puppets on TV";
                    break;
                }
            case 50:
                {
                    text.text = "There is comfort in the strings";
                    break;
                }
            case 52:
                {
                    text.text = "If you're gonna control me";
                    break;
                }
            case 54:
                {
                    text.text = "At least make it interesting theatrically";
                    break;
                }
            case 57:
                {
                    text.text = " ";
                    break;
                }
            case 59:
                {
                    text.text = "How does it feel to be free?";
                    break;
                }
            case 63:
                {
                    text.text = "Hmm";
                    break;
                }
            case 64:
                {
                    text.text = "Why don't you try it yourself?";
                    break;
                }
            case 67:
                {
                    text.text = " ";
                    break;
                }
            case 68:
                {
                    text.text = "The gate opened on me";
                    break;
                }
            case 71:
                {
                    text.text = "So i leaped";
                    break;
                }
            case 73:
                {
                    text.text = "Down, down and down I go";
                    break;
                }
            case 74:
                {
                    text.text = "I tell myself I'm a tough girl";
                    break;
                }
            case 76:
                {
                    text.text = "Down, down and down I go";
                    break;
                }
            case 78:
                {
                    text.text = "I could never, ever, ever touch the soil";
                    break;
                }
            case 81:
                {
                    text.text = "My heart goes right";
                    break;
                }
            case 83:
                {
                    text.text = "My head goes left";
                    break;
                }
            case 85:
                {
                    text.text = "And end up on your bed";
                    break;
                }
            case 87:
                {
                    text.text = "Huh";
                    break;
                }
            case 88:
                {
                    text.text = " ";
                    break;
                }
            case 89:
                {
                    text.text = "Sure I'll be your marionette";
                    break;
                }
            case 91:
                {
                    text.text = "Here, tug on my thread";
                    break;
                }
            case 93:
                {
                    text.text = "Spread me open for dolly pink\nsnow white artificial beauty";
                    break;
                }
            case 97:
                {
                    text.text = "Maybe we're all cold machines";
                    break;
                }
            case 99:
                {
                    text.text = "Stuffed in the human skin";
                    break;
                }
            case 102:
                {
                    text.text = "With human sins";
                    break;
                }
            case 103:
                {
                    text.text = "Sewed up by the gods of city";
                    break;
                }
            case 105:
                {
                    text.text = "Cut it out, you've already lost";
                    break;
                }
            case 108:
                {
                    text.text = "All that precious bravery is gonna get you hurt";
                    break;
                }
            case 111:
                {
                    text.text = "In a world that feeds on the minority";
                    break;
                }
            case 113:
                {
                    text.text = "May that self-centered belief lead you to peace";
                    break;
                }
            case 118:
                {
                    text.text = "If you're gonna replace me";
                    break;
                }
            case 120:
                {
                    text.text = "At least have teh audacity to kill me thoroughly";
                    break;
                }
            case 123:
                {
                    text.text = " ";
                    break;
                }
            case 126:
                {
                    text.text = "When does it end for me?";
                    break;
                }
            case 128:
                {
                    text.text = " ";
                    break;
                }
            case 129:
                {
                    text.text = "Hmm";
                    break;
                }
            case 130:
                {
                    text.text = "I think I am done with everything";
                    break;
                }
            case 133:
                {
                    text.text = " ";
                    break;
                }
            case 134:
                {
                    text.text = "Now I'm ready to leave";
                    break;
                }
            case 138:
                {
                    text.text = "Dragging out";
                    break;
                }
            case 139:
                {
                    text.text = "One lines, Two lines Three lines";
                    break;
                }
            case 141:
                {
                    text.text = "Connect out hands";
                    break;
                }
            case 142:
                {
                    text.text = "When I no longer can live on knowledge alone";
                    break;
                }
            case 146:
                {
                    text.text = "You gave me strength";
                    break;
                }
            case 147:
                {
                    text.text = "You gave me strength\nHopeful curiosity";
                    break;
                }
            case 149:
                {
                    text.text = "Hopeful curiosity\nMaybe there are still happy answers left for my discovery";
                    break;
                }
            case 151:
                {
                    text.text = "Maybe there are still happy answeres left for my discovery,";
                    break;
                }
            case 153:
                {
                    text.text = "What's the colour of the electric sheep do you see?";
                    break;
                }
            case 157:
                {
                    text.text = "And if you love me";
                    break;
                }
            case 159:
                {
                    text.text = "Can you love everything too, for me?";
                    break;
                }
            case 163:
                {
                    text.text = " ";
                    break;
                }
        }
    }
}