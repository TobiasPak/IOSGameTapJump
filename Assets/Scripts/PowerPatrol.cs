// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PowerPatrol : MonoBehaviour
// {
//     public Transform cam;
//     public Transform power;

//     public float powerVelocity;
//     public bool Right;

//     void Update()
//     {

//         if (Right == true)
//         {
//             transform.Translate(2 * Time.deltaTime * powerVelocity, 0, 0);
//         }
//         else
//         {
//             transform.Translate(-2 * Time.deltaTime * powerVelocity, 0, 0);
//         }

//         if (power.position.x < cam.position.x - 2)
//         {
//             Right = true;
//         }
//         else if (power.position.x > cam.position.x + 2)
//         {
//             Right = false;
//         }
//     }
// }
