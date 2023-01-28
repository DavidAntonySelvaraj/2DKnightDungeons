using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float jumpForce;

    private Rigidbody2D playerRb;

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            playerRb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            Debug.Log("Jump" + context.phase);
        }
    }


}//class














