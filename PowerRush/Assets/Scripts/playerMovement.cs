using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxcollider2d;
    public float moveSpeed = 3f;
    private void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxcollider2d = transform.GetComponent<BoxCollider2D>();
    }
    void FixedUpdate()
    {
        Vector2 playerPos = transform.position;
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            playerPos.x += moveSpeed * Time.deltaTime;
        }

        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            playerPos.x -= moveSpeed * Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 10f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }
        transform.position = playerPos;

        private bool IsGrounded()
        {
            Physics2D.BoxCast(boxcollider2d.bounds.center, boxcollider2d.bounds.size, 0f, Vector2.down * .1f);
        }
    }
}
