﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update

    public static int score = 0;
    UnityEngine.UI.Text scoreText;
    void Start()
    {
        scoreText = GetComponent<UnityEngine.UI.Text>();
        scoreText.color= new Color(255,255,255,0.6f);

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + score;
    }
}
