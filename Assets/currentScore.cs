using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class currentScore : MonoBehaviour
{
    public TMP_Text Highscore;
    public TMP_Text HpScore;
    public int Score = 0;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Highscore.text = "Score: " + Score;
        Debug.Log(Player.GetComponent<playerScript>().playerHP);
        HpScore.text = "HP: " + Player.GetComponent<playerScript>().playerHP;
    }
}
