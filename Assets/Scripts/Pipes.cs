using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    
    void Update()
    {
        transform.Translate(Vector3.left * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Endpipe"))
        {
            Destroy(this.gameObject);
        }
    }
}
