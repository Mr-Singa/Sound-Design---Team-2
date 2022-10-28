using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public float SPEED;
    public Rigidbody2D rb;

    Vector2 movement;

    public AudioSource footstepsNormal;
    public AudioSource footstepsWet;
    public AudioSource panting;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            footstepsNormal.enabled = true;
        }
        else
        {
            footstepsNormal.enabled = false;

        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * SPEED * Time.fixedDeltaTime);
    }
}
