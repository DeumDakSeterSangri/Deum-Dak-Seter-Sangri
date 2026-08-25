using UnityEngine;

public class GasaGo : MonoBehaviour
{
    private ScoreChanger _ScoreChanger;
    
    void Start()
    {
        _ScoreChanger = FindObjectOfType<ScoreChanger>();
        _ScoreChanger.GasaGo();
    }
}
