using TMPro;
using UnityEngine;

public class Delaytextchanger : MonoBehaviour
{
    public TMP_Text Delaytext;
    private GameManager _gameManager;
    private audiotimeing _audiotimeing;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _audiotimeing = FindObjectOfType<audiotimeing>();
    }

    // Update is called once per frame
    void Update()
    {
        Delaytext.text = _gameManager.Delay.ToString();
    }

    public void Delay_Up()
    {
        _gameManager.Delay += 0.02f;
    }
    public void Delay_Down()
    {
        _gameManager.Delay -= 0.02f;
    }
}
