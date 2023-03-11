using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float radius = 0.54f;

    private float moveVectorHorizontal, moveVectorVertical;

    private Rigidbody2D playerRb;

    private Transform playerTransform;

    private bool canMove;

    private void Awake()
    {
        playerTransform = GetComponent<Transform>();
        playerRb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        moveVectorHorizontal = Input.GetAxisRaw("Horizontal");
        moveVectorVertical = Input.GetAxisRaw("Vertical");

        //Debug.Log("Move Vector"+" "+"("+moveVectorHorizontal+","+moveVectorVertical+")");
        CanMovePlayer();
        MovePlayer();
    }
    void CanMovePlayer()
    {
        RaycastHit2D hit = Physics2D.Raycast(playerTransform.position, transform.right, radius, 3 << LayerMask.NameToLayer("Wall"));

        //Debug.DrawRay(transform.position, transform.right, Color.white);

        if (hit)
        {
            canMove = false;
        }
        else
        {
            canMove = true;
        }
    }


    void MovePlayer()
    {
        if (canMove)
        {
            playerRb.velocity = new Vector2(moveVectorHorizontal*moveSpeed,moveVectorVertical*moveSpeed);
            //Debug.Log("MOVE");
        }
        else
        {
            playerRb.velocity = new Vector2(0,0);
            //Debug.Log("CANT MOVE");
        }
    }

}//class










