using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class winScreenFadeScript : MonoBehaviour
{
    private TMP_Text winScreen;
    private Color fadeColour;

    // Start is called before the first frame update
    void Start()
    {
        winScreen = GetComponent<TMP_Text>();
 
    }

    // Update is called once per frame
    void Update()
    {
        winScreen.color += fadeColour;
        fadeColour.a = 0.001f;
    }
}
