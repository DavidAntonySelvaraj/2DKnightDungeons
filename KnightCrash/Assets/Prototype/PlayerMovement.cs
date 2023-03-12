using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float radiusRaycast;

    private float moveVectorHorizontal, moveVectorVertical;

    private Rigidbody2D playerRb;


    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        moveVectorHorizontal = Input.GetAxisRaw("Horizontal");
        moveVectorVertical = Input.GetAxisRaw("Vertical");

        //Debug.Log("Move Vector"+" "+"("+moveVectorHorizontal+","+moveVectorVertical+")");
        MovePlayer();
    }

    void MovePlayer()
    {
        RaycastHit2D hitL = Physics2D.Raycast(transform.position, -transform.right, radiusRaycast,3<<LayerMask.NameToLayer("Wall"));
        RaycastHit2D hitR = Physics2D.Raycast(transform.position, transform.right, radiusRaycast, 3 << LayerMask.NameToLayer("Wall"));
        RaycastHit2D hitU = Physics2D.Raycast(transform.position, transform.up, radiusRaycast, 3 << LayerMask.NameToLayer("Wall"));
        RaycastHit2D hitD = Physics2D.Raycast(transform.position, -transform.up, radiusRaycast, 3 << LayerMask.NameToLayer("Wall"));

        if ( moveVectorHorizontal == 1  )
        {

            MoveRight();

        }
        else if( moveVectorHorizontal == -1 )
        {

            MoveLeft();

        }
        else if ( moveVectorVertical == 1)
        {

            MoveUp();

        }
        else if (moveVectorVertical == -1)
        {

            MoveDown(); ;

        }



    }


    void MoveRight()
    {
        if (playerRb.velocity == new Vector2(0, 0))
        {
            playerRb.velocity = new Vector2(moveSpeed, playerRb.velocity.y);
        }
    }

    void MoveLeft()
    {
        if (playerRb.velocity == new Vector2(0, 0))
        {
            playerRb.velocity = new Vector2(-moveSpeed, playerRb.velocity.y);
        }
    }

    void MoveUp()
    {
        if (playerRb.velocity == new Vector2(0, 0))
        {
            playerRb.velocity = new Vector2(playerRb.velocity.x, moveSpeed);
        }
    }

    void MoveDown()
    {
        if (playerRb.velocity == new Vector2(0, 0))
        {
            playerRb.velocity = new Vector2(playerRb.velocity.x, -moveSpeed);
        }
    }
    

}//class










