using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Interaction : MonoBehaviour
{
    float jumpVelocity = 8f;
    public Transform player;
    public GameObject restartPanel;
    float diffScore = 100f;

    private Rigidbody2D rigidbody2d;

    // public SpriteRenderer spriteRenderer;
    // public Sprite newSprite;
    // public Sprite ogSprite;


    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

// Update is called once per frame
    public void Update()
    {
        if (player.position.y >= diffScore && jumpVelocity >= 3.5f)
        {
            jumpVelocity *= 0.9f;
            diffScore *= 2f;
        }
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if ((touch.phase == TouchPhase.Began) && (restartPanel.activeSelf == false))
            {
                rigidbody2d.velocity = Vector2.up * jumpVelocity;
            }
        }
    }


}
