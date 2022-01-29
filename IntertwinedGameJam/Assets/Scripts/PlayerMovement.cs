using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    public FMODUnity.StudioEventEmitter Steps;
    
    public bool stepsPlaying = false;

    public float timerThresh = 1;

    public float t;







    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        restart();
        
        if(stepsPlaying == false)
        {
            if(Input.GetKey(KeyCode.W))
                {
                    Steps.SendMessage("Play");
                    stepsPlaying = true;
                }
        }
      
      if(stepsPlaying == false)
        {
            if(Input.GetKey(KeyCode.A))
                {
                    Steps.SendMessage("Play");
                    stepsPlaying = true;
                }
        }
       if(stepsPlaying == false)
        {
            if(Input.GetKey(KeyCode.S))
                {
                    Steps.SendMessage("Play");
                    stepsPlaying = true;
                }
        }
       
       if(stepsPlaying == false)
        {
            if(Input.GetKey(KeyCode.D))
                {
                    Steps.SendMessage("Play");
                    stepsPlaying = true;
                }
        }
        timer();
        
       
        
     
    }


    void restart()
    {
        if(Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Level1");
        }
    }

    void timer()
    {
        if(stepsPlaying)
        {
            t += Time.deltaTime;
            if(t>=timerThresh)
            {
                stepsPlaying = false;
                t = 0f;
            }
        }
    }



    private void FixedUpdate() 
    {
    rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);    
    }
}
