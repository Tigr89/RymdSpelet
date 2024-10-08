using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{

    public static scoreManager instance;

    public Text currentScoreText;
    public Text highScoreText;

    int score = 0;
    int highScore = 0;


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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addPoint()
    {
        score += 10;
        currentScoreText.text = score.ToString() + " POINTS";
        if(highScore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

}
