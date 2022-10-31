using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public float SPEED;

    public AudioSource footstepsNormal;
    public AudioSource footstepsWet;
    public AudioSource panting;

    void Update()
    {
        Movement();
        Rotate();
    }

    public void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * SPEED * Time.deltaTime;
            footstepsNormal.enabled = true;
        }
        else
        {
            footstepsNormal.enabled = false;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.up * -SPEED * Time.deltaTime;
            footstepsNormal.enabled = true;
        }
        else
        {
            footstepsNormal.enabled = false;
        }
    }

    public void Rotate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, SPEED * 10 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -SPEED * 10 * Time.deltaTime);
        }
    }
}
