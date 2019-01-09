using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerJamp : MonoBehaviour
{
    public AudioClip Butt;
    public float speed = 1f;
    private Rigidbody2D rb;
    private bool isGrounded = false;
    public Transform groundCheck;
   
    private float groundRadius = 0.1f;

    public LayerMask whatIsGround;
    private Animator anim;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        if (!isGrounded)
            return;
    }
        void Update () {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
           
            rb.AddForce(new Vector2(0, 20000));
            anim.Play("Jump");
            AudioSource.PlayClipAtPoint(Butt, transform.position);
        }

           }







    }

