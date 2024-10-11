using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{

    public static UIScript instance;

    public GameObject enemyShip;
    private enemyBehaviour enemyBehaviour;

    public Text currentScoreText;
    public Text highScoreText;

    int score = 0;
    int highScore = 0;

    public Sprite[] healthSprite;
    public GameObject[] healthImage;

    //Player Health
    public int playerHealth;
    public int playerMaxHealth;
    public int playerExtraLives;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore", 0);
        currentScoreText.text = score.ToString() + " POINTS";
        highScoreText.text = "HIGH SCORE: " + highScore.ToString();

        //Sets player health to its maximum
        playerHealth = playerMaxHealth;


    }

    // Update is called once per frame
    void Update()
    {

    }

    //Let's the player lose health
    public void takeDamage(int damage)
    {
        playerHealth -= damage;

        //What to do if player runs out of health
        if (playerHealth <= 0)
        {
            playerExtraLives--;
            if (playerExtraLives <= 0) 
            {
                //GAME OVER SCREEN!
            }
        }
    }

    //Adds points on kills and keeps highscore
    public void addPoint(int enemyValue)
    {
        score += enemyValue;
        currentScoreText.text = score.ToString() + " POINTS";
        if(highScore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

}
