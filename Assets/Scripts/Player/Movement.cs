using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using System;

public class Movement : MonoBehaviour
{

    public float speed = 5;
    public int facingDirection = 1;
    public Rigidbody2D rb;

    public Animator playeranim;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal > 0 && transform.localScale.x < 0 || horizontal <0 && transform.localScale.x > 0 )
        {
            Flip();
        }

        playeranim.SetFloat("horizontal", Mathf.Abs(horizontal));
        playeranim.SetFloat("vertical", Mathf.Abs(vertical));

        rb.linearVelocity = new Vector2(horizontal, vertical) * speed;
    }

    public void Flip()
    {
        facingDirection *= -1;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);

    }
}
