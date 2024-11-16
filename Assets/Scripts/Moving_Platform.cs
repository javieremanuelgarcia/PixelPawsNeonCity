using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 2f; 
    public float height = 3f;

    private Vector3 startPos;
    private bool movingUp = true;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        MovePlatform();
    }

    void MovePlatform()
    {
        if (movingUp)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            if (transform.position.y >= startPos.y + height)
            {
                movingUp = false;
            }
        }
        else
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
            if (transform.position.y <= startPos.y)
            {
                movingUp = true;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}
