using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    private Rigidbody2D playerRb;


    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        movePlayer();
    }


    void movePlayer()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(transform.position.x + moveSpeed*Time.deltaTime, transform.position.y, transform.position.z);

            
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
          //  playerRb.velocity = new Vector2(playerRb.velocity.x + moveSpeed * Time.deltaTime, 0);
        }
    }

   

}//class










