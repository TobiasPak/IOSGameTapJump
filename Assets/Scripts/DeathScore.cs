using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScore : MonoBehaviour
{

    public Score score;
    public Text scoreText;

    void Start()
    {
        scoreText.text = "Score: " + score.finalScore.ToString("0");
    }
 
}
