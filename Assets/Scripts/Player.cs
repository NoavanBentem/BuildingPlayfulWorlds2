using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
    private Rigidbody rb;

    private bool movingRight = false;
    private bool canMove = true;
    [SerializeField]
    float speed = 4f;


	void Start () 
    {
        rb = this.GetComponent<Rigidbody>();

	}
	

	void Update () 
    {  
     // Calling fuctions reacting to the left mouse button   
        if (Input.GetMouseButtonDown(0) && canMove)
        {
            ChangeBool();
            ChangeDirection();

        // Checks if player isn't walking in freaking air
            if (Physics.Raycast(this.transform.position, Vector3.down * 2) == false)
            {
                FallDown();
            }
        }
	}
// Inverts moving right bool 
    private void ChangeBool()
    {
        movingRight = !movingRight;    
    }

// Swithes the moving dirtection based on the given bool state
    private void ChangeDirection()
    {
        if(movingRight)
        {
            rb.velocity = new Vector3(speed, 0f, 0f);
        }
        else
        {
            rb.velocity = new Vector3(0f, 0f, speed);
        }
    }

// Makes player fall if player is trying to fly away
    private void FallDown()
    {
        canMove = false;
        rb.velocity = new Vector3(0f, -4f, 0f);
    }

    private void Move()
    {
        
    }
}
