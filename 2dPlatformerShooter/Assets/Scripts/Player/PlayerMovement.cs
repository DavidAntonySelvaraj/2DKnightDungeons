using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float jumpForce;

    [SerializeField]
    private float moveSpeed = 8f;

    private Animator anim;

    private SpriteRenderer sr;

    private float moveDir;

    private Rigidbody2D playerRb;

    private PlayerInput playerInput;

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        moveDir = Input.GetAxis("Horizontal");
        FlipPlayer();


        //moveDir = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        PlayerAnimation();
        Move();
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            playerRb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            Debug.Log("Jump" + context.phase);
        }
    }

    void Move()
    {
        //anim.SetBool("canMove", true);
        transform.position = new Vector2(transform.position.x+moveSpeed*moveDir*Time.deltaTime, transform.position.y);
    }

    void PlayerAnimation()
    {
        if (moveDir == 0)
        {
            anim.SetBool("canRun", false);
        }else
        {
            anim.SetBool("canRun", true);
        }
    }


    void FlipPlayer()
    {
        if (moveDir < 0)
        {
            sr.flipX = true;
        }
        else if (moveDir > 0)
        {
            sr.flipX = false;
        }
    }




}//class














