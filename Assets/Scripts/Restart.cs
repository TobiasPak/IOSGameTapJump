using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public GameObject restartPanel;
    public GameObject score;
    public Transform camPos;
    public Transform playerPos;

    public GameObject startPanel;
    public GameObject gameScore;

    public bool alive;

    void Start()
    {
        alive = true;
    }

    void OnTriggerEnter2D(Collider2D collE)
    {
        if (collE.gameObject.name == "EnemyEagle" || collE.gameObject.name == "EnemyDrone")
        {
            restartPanel.SetActive(true);
            score.SetActive(false);
            alive = false;
        }

    }

    void Update() 
    {
        float minY = camPos.position.y - 6;
        float charPos = playerPos.position.y;
        if (minY > charPos)
        {
            restartPanel.SetActive(true);
            score.SetActive(false);
            alive = false;
        }
        if ((Input.touchCount > 0) && (alive == true))
        {
            startPanel.SetActive(false);
            gameScore.SetActive(true);
            
        }
    }

}
