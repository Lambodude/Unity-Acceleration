using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class Score : MonoBehaviour
{

    public static Score instance; 

    public int score = 0;
    public Text scoretxt;
   
    void Update()
    {
        scoretxt.text = ("Score: " + score);
    }

    public void IncreaseScore()
    {
        score++;
    }
}
