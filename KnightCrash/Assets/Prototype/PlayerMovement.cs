using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float radius;

    private Transform playerTransform;

    private bool canMove;

    private void Awake()
    {
        playerTransform = GetComponent<Transform>();
    }
    private void FixedUpdate()
    {
        CanMovePlayer();
    }
    void CanMovePlayer()
    {
        RaycastHit2D hit = Physics2D.Raycast(playerTransform.position, transform.right, radius, 3 << LayerMask.NameToLayer("Wall"));

        //Debug.DrawRay(transform.position, transform.right, Color.white);

        if (hit)
        {
            Debug.Log("Its Hit");
        }
        else
        {
            Debug.Log("Not hit");
        }
    }

}//class










