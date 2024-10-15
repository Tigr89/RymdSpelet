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

        //när playerHP är noll eller mindre
        //canvas blir active
        //////////////////OM DET SKA FADE:A  - skriv det i gameOver-objektets egna script
        // & skriver in text:

        if (playerHP <= 0)
        {
            gameOver.SetActive(true);
            //&& FindWithTag("Player") != null
            gameOver.GetComponent<TMP_Text>().text = "YOU DIED :(";
        }


        //när playerScore är 10 eller mer
        //canvas blir active
        //sluta spawna enemy och meteor
        //& skriver in text:
        if (playerScore >= 10)
        {
            winScreen.SetActive(true);
            winScreen.GetComponent<TMP_Text>().text = "YOU WIN!";
        }
        

    }
}
