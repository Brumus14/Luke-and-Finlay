using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private LayerMask LevelLayerMask;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    public float moveSpeed = 3f;
    private void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 10f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }
    }
    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down * 0.1f, LevelLayerMask);
        Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;
    }   
    private void FixedUpdate()
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
        transform.position = playerPos;
    }
}
