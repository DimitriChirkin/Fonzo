using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyboardController : MonoBehaviour
{

    public Player Player;
    private bool isGrounded = false;

    public Transform groundCheck;

    private float groundRadius = 0.1f;

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        if (!isGrounded)
            return;
    }
    public LayerMask whatIsGround;
    private void Start()
    {

        Player = Player == null ? GetComponent<Player>() : Player;
        if (Player == null)
        {
            Debug.LogError("Player not set to controller");
        }
    }

    private void Update()
    {

        if (isGrounded && Player != null)
        {

            if (Input.GetKey(KeyCode.D))
            {
                Player.MoveRight();
            }
            if (Input.GetKey(KeyCode.A))
            {
                Player.MoveLeft();
            }
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.LoadLevel("GameMenu");
            }

        }

     
        

    }
}
