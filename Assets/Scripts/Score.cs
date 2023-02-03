using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    // Update is called once per frame

    public float finalScore;

    void Start()
    {
        finalScore = 0;
    }


    public void Update()
    {
        float pPos = player.position.y;
        if (finalScore < pPos)
        {
            finalScore = pPos;
        }
        scoreText.text = finalScore.ToString("0");
    }
}
