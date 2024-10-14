using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class UIscript : MonoBehaviour
{
    public TMP_Text scoreText;
    public int scoreValue;
    /*public Sprite[] healthSprite;
    //Sprite 1 == Sprite[0]
    //Sprite 2 == Sprite[1]
    //Sprite 3 == Sprite[2]*/

    public GameObject[] healthImage;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Test";

        for(int i = 0; i < 3; i++)
        {
            //healthImage[i].sprite = healthSprite[i];
        
        }
        //
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreValue.ToString();

        /*if(x < 3)
        {
            healthImage[2].SetActive(false);
        }

        if (x < 2)
        {
            healthImage[1].SetActive(false);
        }

        if (x < 1)
        {
            healthImage[0].SetActive(false);
        }*/
    }

    public void UpdateHealth(int healthNumber)
    {
        healthImage[healthNumber].SetActive(false);
    }



}
