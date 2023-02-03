using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyPatrol : MonoBehaviour
{
    public Transform cam;
    public Transform enemy;

    public float enemyVelocity;
    public bool Right;

    void Update()
    {

        if (Right == true)
        {
            transform.Translate(2 * Time.deltaTime * enemyVelocity, 0, 0);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * enemyVelocity, 0, 0);
        }

        if (enemy.position.x < cam.position.x - 2)
        {
            Right = true;
        }
        else if (enemy.position.x > cam.position.x + 2)
        {
            Right = false;
        }
    }
}
