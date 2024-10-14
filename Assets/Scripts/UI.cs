using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    public Image HPImage;
    public TMP_Text scoreText;
    public int playerScore;

    public TMP_Text HPValue;
    public int playerHP;

    public GameObject gameOver;
    public GameObject winScreen;

    //public float alpha;
    //CanvasGroup canvasGroup;


    // Start is called before the first frame update
    void Start()
    {
        //canvasGroup = GetComponent<CanvasGroup>();
        gameOver = GameObject.Find("gameOver");
        gameOver.SetActive(false);
        winScreen = GameObject.Find("winScreen");
        winScreen.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + playerScore.ToString();

        HPValue.text = "HP: " + playerHP.ToString();

        //n�r playerHP �r noll eller mindre
        //h�j canvas gameOver's group alpha till 1
        //OM DET SKA FADE:A  - skriv det i gameOver-objektets egna script
        // & skriv in text:

        if (playerHP <= 0)
        {
            gameOver.SetActive(true);
            gameOver.GetComponent<TMP_Text>().text = "YOU DIED :(";
        }


        //n�r playerScore �r 10 eller mer
        //sluta spawna enemy och meteor
        //h�j canvas winScreen's group alpha till 1
        //& skriv in text:
        if (playerScore >= 10)
        {
            winScreen.SetActive(true);
            winScreen.GetComponent<TMP_Text>().text = "YOU WIN!";
        }
        

    }
}
