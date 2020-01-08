using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
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
        transform.position = playerPos;
    }
}
