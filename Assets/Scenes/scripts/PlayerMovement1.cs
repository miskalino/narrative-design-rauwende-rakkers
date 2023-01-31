using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb2D;
    private bool onGround;

    // Awake is called everytime script is loaded
    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float horizontal_in = Input.GetAxis("Horizontal");
        rb2D.velocity = new Vector2(horizontal_in * speed, rb2D.velocity.y);

        //flip character
        if (horizontal_in > 0.01f)
        {
            transform.localScale = Vector3.one;
        }
        else if (horizontal_in < -0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        // jumping check
        if (Input.GetKey(KeyCode.Space) && onGround)
        {
            jump();
        }
    }

    // jumping
    private void jump()
    {
        rb2D.velocity = new Vector2(rb2D.velocity.x, speed);
        onGround = false;
    }
    // ground collision check
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            onGround = true;
        }
    }
}