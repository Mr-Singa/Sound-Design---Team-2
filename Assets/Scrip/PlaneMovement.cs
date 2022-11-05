using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public float SPEED = 0;
    public float WALKSPEED;
    public float SPRINTSPEED;

    public MoveMode moveMode = MoveMode.Walking;

    public float maxSprintDuration;
    float sprintingTime = 0;
    public float pantingDuration;
    float pantingTime = 0;

    public AudioSource footstepsNormal;
    public AudioSource footstepsWet;
    public AudioSource sprinting;
    public AudioSource panting;

    void Update()
    {
        Movement();
        Rotate();
    }

    public void Movement()
    {
        switch (moveMode)
        {
            case MoveMode.Walking:
                SPEED = WALKSPEED;
                panting.enabled = false;
                sprinting.enabled = false;

                if (sprintingTime > 0)
                    sprintingTime -= Time.deltaTime;

                if (Input.GetKey(KeyCode.LeftShift))
                    moveMode = MoveMode.Sprinting;

                break;

            case MoveMode.Sprinting:
                SPEED = SPRINTSPEED;
                sprintingTime += Time.deltaTime;
                panting.enabled = false;
                footstepsNormal.enabled = false;

                if (sprintingTime > maxSprintDuration)
                {
                    pantingTime = 0;
                    moveMode = MoveMode.Panting;
                }


                if (!Input.GetKey(KeyCode.LeftShift))
                    moveMode = MoveMode.Walking;
                
                break;

            case MoveMode.Panting:
                SPEED = WALKSPEED;
                pantingTime += Time.deltaTime;
                panting.enabled = true;
                sprinting.enabled = false;

                if (pantingTime > pantingDuration)
                {
                    sprintingTime = 0;
                    moveMode = MoveMode.Walking;
                    
                }

                break;
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * SPEED * Time.deltaTime;

            if (moveMode == MoveMode.Sprinting)
                sprinting.enabled = true;
            else
                footstepsNormal.enabled = true;
            
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.up * -SPEED * Time.deltaTime;
            
            if (moveMode == MoveMode.Sprinting)
                sprinting.enabled = true;
            else
                footstepsNormal.enabled = true;
        }
        else
        {
            sprinting.enabled = false;
            footstepsNormal.enabled = false;
        }
    }

    public void Rotate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, SPEED * 25 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -SPEED * 25 * Time.deltaTime);
        }
    }

    public enum MoveMode
    {
        Walking,
        Sprinting,
        Panting
    }
}
