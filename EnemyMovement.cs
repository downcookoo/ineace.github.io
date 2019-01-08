using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public float moveSpeed;
    public bool moveRight;
    public Transform wallCheck;
    public float wallCheckradius;
    public LayerMask whatIsWall;
    private bool HittingWall;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        HittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckradius, whatIsWall);

        if (HittingWall)
        {
            moveRight = !moveRight;
        }
        
       

        if (moveRight)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
            
	}
}
