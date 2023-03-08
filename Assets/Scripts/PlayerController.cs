using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float force;
    private Rigidbody2D rb;
    private Animator anim;

    public Text scoreText;
    public int scoreCount;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * force;
            anim.SetBool("Clicked", true);
        }
        else
        {
            anim.SetBool("Clicked", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PipeScore")) ;
        {
            scoreCount++;
            scoreText.text = scoreCount.ToString();

        }
    }
}
