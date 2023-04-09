using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreBoard2: MonoBehaviour
{
    public TMP_Text scoreText;

    public void score(int currentScore)
    {
        scoreText.text = "P2 Score: " + currentScore;
    }
    // Start is called before the first frame update
}
