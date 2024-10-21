using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gameOverFadeScript : MonoBehaviour
{
    private TMP_Text gameOverScreen;
    private Color fadeColour;

    // Start is called before the first frame update
    void Start()
    {
        gameOverScreen = GetComponent<TMP_Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        gameOverScreen.color += fadeColour;
        fadeColour.a = 0.001f;
    }
}
