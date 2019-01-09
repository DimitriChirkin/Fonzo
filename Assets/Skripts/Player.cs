using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    [Header("Speeds")]
    public float WalkSpeed = 3;
    public float JumpForce = 10;
    public int i=0;
    private MoveState _moveState = MoveState.Idle;
    private DirectionState _directionState = DirectionState.Right;
    private Transform _transform;
    private Rigidbody2D _rigidbody;
    private Animator _animatorController;
    private float _walkTime = 0, _walkCooldown = 0.2f;
    private bool isGrounded = false;

    public Transform groundCheck;

    private float groundRadius = 0.1f;

    public LayerMask whatIsGround;
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        if (!isGrounded)
            return;
    }

    public void MoveRight()
    {
        if (_moveState != MoveState.Jump)
        {
            _moveState = MoveState.Walk;
            if (_directionState == DirectionState.Left)
            {
                _transform.localScale = new Vector3(-_transform.localScale.x, _transform.localScale.y, _transform.localScale.z);
                _directionState = DirectionState.Right;
            }
            _walkTime = _walkCooldown;
            _animatorController.Play("Walk");
        }
    }

    public void MoveLeft()
    {
        if (_moveState != MoveState.Jump)
        {
            _moveState = MoveState.Walk;
            if (_directionState == DirectionState.Right)
            {
                _transform.localScale = new Vector3(-_transform.localScale.x, _transform.localScale.y, _transform.localScale.z);
                _directionState = DirectionState.Left;
            }
            _walkTime = _walkCooldown;
            _animatorController.Play("Walk");
        }
    }

  

    private void Idle()
    {
        if (isGrounded)
        {
            _moveState = MoveState.Idle;
            _animatorController.Play("Idle");
        }
    }
    private void Jump()
    {
        
        
            _animatorController.Play("Jump");
        
    }

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _animatorController = GetComponent<Animator>();
        _directionState = transform.localScale.x > 0 ? DirectionState.Right : DirectionState.Left;
    }

    private void Update()
    {
    
       
        if (isGrounded== false)
        {

            _animatorController.Play("Jump");


        }

     
        if (_moveState == MoveState.Walk)
        {
            _rigidbody.velocity = ((_directionState == DirectionState.Right ? Vector2.right : -Vector2.right)* WalkSpeed * Time.deltaTime);
            _walkTime -= Time.deltaTime;
            if (_walkTime <= 0)
            {
                Idle();
            }
        }
    }

    enum DirectionState
    {
        Right,
        Left
    }

    enum MoveState
    {
        Idle,
        Walk,
        Jump
    }
}