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

        if ( !hitR && moveVectorHorizontal == 1 )
        {

            playerRb.velocity = new Vector2(moveSpeed,playerRb.velocity.y);

        }
        if(!hitL && moveVectorHorizontal == -1)
        {

            playerRb.velocity = new Vector2(-moveSpeed, playerRb.velocity.y);

        }
        if (!hitU && moveVectorVertical == 1)
        {

            playerRb.velocity = new Vector2( playerRb.velocity.x, moveSpeed);

        }
        if (!hitD && moveVectorVertical == -1)
        {

            playerRb.velocity = new Vector2( playerRb.velocity.x, -moveSpeed);

        }



    }

    void MovePlayerRight()
    {
         playerRb.velocity = new Vector2(moveSpeed,playerRb.velocity.y);
    }

}//class










