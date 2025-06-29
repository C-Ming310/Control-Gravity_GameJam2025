using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarFit : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.transform.parent == transform.parent)
        {
            GetComponent<PlayerMove>().enabled = false;
            rb.velocity = Vector2.zero;
            transform.position = other.transform.position;
        }
    }
}
