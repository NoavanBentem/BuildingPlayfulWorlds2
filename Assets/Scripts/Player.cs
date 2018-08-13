using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour 
{
    private Rigidbody rb;

    private bool movingRight = true;
    private bool canMove = true;


    public float speed = 10f;
    private Vector3 jump;
    public float jumpForce = 2.0f;
    private bool isGrounded;

    public bool gameOver = false;
    public float gameTimer;
    public int seconds = 0;

    public ParticleSystem jumpParticle;
    public ParticleSystem doubleJumpParticle;


	private void Start () 
    {
        rb = this.GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);

	}

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }

    private void Update () 
    {  

     // Calling fuctions reacting to the left mouse button   
        if (Input.GetMouseButtonDown(0) && canMove)
        {
            ChangeBool();
            ChangeDirection();
        }

        // Checks if player isn't walking in freaking air
        if (Physics.Raycast(this.transform.position, Vector3.down * 2) == false)
        {
            FallDown();
            Timer();
            if (seconds == 4)
            {
                gameOver = true;
            }
        }

        if (gameOver == true)
        {
            SceneManager.LoadScene("Menu");
        }

        // Checks if spcae is pressed
        if (Input.GetKey(KeyCode.Space))
        {
            
            if (isGrounded)
            {
                rb.AddForce(jump * jumpForce);
                isGrounded = false;
                jumpParticle.Play();

            }

            // Doublejump woop woop
            else
            {
                if (!isGrounded)
                {

                    rb.AddForce(jump * jumpForce);
                    doubleJumpParticle.Play();
                }
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

    void Timer()
    {
        if (Time.time > gameTimer + 1)
        {
            gameTimer = Time.time;
            seconds++;
        }
    }

}
