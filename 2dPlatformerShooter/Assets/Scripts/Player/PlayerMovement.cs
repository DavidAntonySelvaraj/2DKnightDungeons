using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float jumpForce;

    private float moveDir;

    private Rigidbody2D playerRb;

    private PlayerInput playerInput;

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        moveDir = Input.GetAxis("Horizontal");
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
        playerRb.
    }


}//class














