using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator playerAnim;
    public Rigidbody playerRigid;
    public float walk_speed, run_speed,ro_speed,olw_speed, wb_speed;
    public bool walking;
    public Transform playerTrans;
    

    /*
    UpArrow	Up arrow key.
    DownArrow	Down arrow key.
    RightArrow	Right arrow key.
    LeftArrow	Left arrow key.
    */
    void FixedUpdate(){
        if(Input.GetKey(KeyCode.UpArrow)){
            playerRigid.velocity = transform.forward * walk_speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            playerRigid.velocity = -transform.forward * walk_speed * Time.deltaTime;
        }
        if(walking == false){
            playerRigid.velocity = -transform.forward * Time.deltaTime;
        }

        if(Input.GetKeyUp(KeyCode.UpArrow)){
            playerRigid.velocity = transform.forward * wb_speed * Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){            
            playerAnim.SetTrigger("walking");
            playerAnim.ResetTrigger("espera");
            walking = true;
        }
        if(Input.GetKeyUp(KeyCode.UpArrow)){            
            playerAnim.ResetTrigger("walking");
            playerAnim.SetTrigger("espera");
            walking = false;
        }
        if(Input.GetKey(KeyCode.DownArrow)){            
            playerAnim.SetTrigger("espera");
            //playerAnim.ResetTrigger("idle");
        }
        if(Input.GetKeyUp(KeyCode.DownArrow)){            
            playerAnim.ResetTrigger("walking");
            playerAnim.SetTrigger("espera");
        }
        if(Input.GetKey(KeyCode.LeftArrow)){            
            playerTrans.Rotate(0, -ro_speed * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow)){            
            playerTrans.Rotate(0, ro_speed * Time.deltaTime, 0);
        }
        if(walking == true){
            if(Input.GetKey(KeyCode.LeftShift)){
                float temp = 120;
                walk_speed = temp + run_speed;
                playerAnim.SetTrigger("running");
                playerAnim.ResetTrigger("walking");                
            }
            if(Input.GetKeyUp(KeyCode.LeftShift) || (Input.GetKeyUp(KeyCode.UpArrow))){
                walk_speed = olw_speed;
                playerAnim.ResetTrigger("running");
                playerAnim.SetTrigger("walking");                
            }
            
        }
        


    }
}
