using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemySpawn : MonoBehaviour
{
    public Transform cam;
    public Transform enemy;
    public Transform topCloud;
    public Transform midCloud;
    public Transform player;

    public float chance;

    public bool check;

    float diffEnemyScore = 150f;
    //public float RandomPosGenerator(float maxYFloat, float minYFloat)
    //{
    //float randomYNum = Random.Range(minYFloat, maxYFloat);
    //}



    void Update()
    {
        float topPosC = topCloud.position.y + 6;
        float botPosC = topCloud.position.y - 6;
        float topMidPosC = midCloud.position.y + 6;
        float botMidPosC = midCloud.position.y - 6;
        float topCamPos = cam.position.y + 5;
        float botCamPos = cam.position.y - 5;
        


        if ((botCamPos >= botMidPosC) && (topCamPos <= topMidPosC))
        {
            float chanceTotal = UnityEngine.Random.Range(0, 100);

            if ((check == true) && (chance >= chanceTotal))
            {
                if (botCamPos > enemy.position.y + 1)
                {
                    //RandomPosGenerator(botPosC, topPosC);
                    float randNum = UnityEngine.Random.Range(botPosC, topPosC);
                    enemy.position = new Vector3(0, randNum, 0);
                    check = false;
                }

            }

        }
        else if ((botCamPos >= botPosC) && (topCamPos <= topPosC))
        {
            check = true;
        }


        if (player.position.y >= diffEnemyScore && chance <= 100f)
        {
            chance *= 1.5f;
            diffEnemyScore *= 2f;
        } 

    }
}
