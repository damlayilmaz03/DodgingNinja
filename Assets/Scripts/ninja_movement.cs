using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ninja_movement : MonoBehaviour
{
    public Animator anim;

    private CharacterController controller;
    private Vector3 playerVelocity;

    private float playerSpeed = 2.0f;
    private bool groundedPlayer;
    private float gravityValue = -4f;
    private float jumpHeight = 2.5f;
    int jump_count_max=1,jump_count=0;
    Rigidbody rb;
    float x,y;

   
    void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        jump_count = jump_count_max;
    }

    
    void Update()
    {

        


        //RUN
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetInteger("move_run", 1);

            
            Vector3 move = new Vector3(0, 0,1);//right move for chacracter
          
            controller.Move(move * Time.deltaTime * playerSpeed);
            if (move != Vector3.zero)
            {
                gameObject.transform.forward = move;
            }

            if (Input.GetKeyDown(KeyCode.Space) && !groundedPlayer)
            {

                playerVelocity.y = jumpHeight*1.2f;

                anim.SetInteger("move_run_jump", 1);
                groundedPlayer = true;
                

            }
            

            else
            {

                anim.SetInteger("move_run_jump", 0);

                playerVelocity.y += gravityValue * Time.deltaTime; //drop down
                controller.Move(playerVelocity * Time.deltaTime);
                

            }


        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetInteger("move_run", 1);
            

            Vector3 move = new Vector3(0, 0,-1); // left move for character
            controller.Move(move * Time.deltaTime * playerSpeed);
            if (move != Vector3.zero)
            {
                gameObject.transform.forward = move;
            }
            if (Input.GetKeyDown(KeyCode.Space) && !groundedPlayer)
            {

                playerVelocity.y = jumpHeight*1.2f;

                anim.SetInteger("move_run_jump", 1);
                groundedPlayer = true;


            }


            else
            {

                anim.SetInteger("move_run_jump", 0);

                playerVelocity.y += gravityValue * Time.deltaTime; //drop down
                controller.Move(playerVelocity * Time.deltaTime);
                

            }

        }

        else
        {
            anim.SetInteger("move_run", 0);
        }
        //JUMP


        
        
        if (Input.GetKeyDown(KeyCode.Space) && !groundedPlayer)
        {
           
                playerVelocity.y = jumpHeight*1.2f;
                anim.SetInteger("move_jump", 1);
                groundedPlayer = true;
                

        }
        else
        {

            anim.SetInteger("move_jump", 0);

            playerVelocity.y += gravityValue * Time.deltaTime; //drop down
            controller.Move(playerVelocity * Time.deltaTime);
            
            

        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("floor"))
        {
            groundedPlayer = false;
        }
    }

}
