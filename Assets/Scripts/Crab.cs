using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class Crab : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 4;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Physics enginge will not rotate Crab
        rb.freezeRotation = true;
        // remove gravity
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            // walk
            float angleRadians = rb.rotation * Mathf.PI / 180f;
            float xSpeed = Mathf.Cos(angleRadians) * speed;
            float ySpeed = Mathf.Sin(angleRadians) * speed;
            rb.velocity = new Vector2(xSpeed, ySpeed);

            if (Input.GetKey(KeyCode.A))
            {
                // and turn left
                rb.rotation += 1;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                // and turn right
                rb.rotation -= 1;
            }
        }
        else
        {
            // do not move
            rb.velocity = Vector2.zero;
        }
    }
}
