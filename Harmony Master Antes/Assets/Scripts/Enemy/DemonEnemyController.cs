using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonEnemyController : MonoBehaviour
{
    public float speed;
    public float MaxSpeed;

    private Rigidbody2D rb2d;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        rb2d.AddForce(Vector2.right * speed);
        float limitedSpeed = Mathf.Clamp(rb2d.velocity.x, -MaxSpeed, MaxSpeed);
        rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);

        if (rb2d.velocity.x > -0.05f && rb2d.velocity.x < 0.05f)
        {
            speed = -speed;

        }
    }
}
