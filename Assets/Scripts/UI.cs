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


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + playerScore.ToString();


        HPValue.text = "HP: " + playerHP.ToString(); 

    }
}
