using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player Hit");
        Time.timeScale = 0f;
        Destroy(gameObject);
    }
}
