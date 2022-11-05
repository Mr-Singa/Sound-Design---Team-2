using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCollision : MonoBehaviour
{
    public PlaneMovement playerMove;

    public AudioSource source;
    public AudioSource winSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Player escasped");

            playerMove.enabled = false;

            source.volume = 0.2f;

            winSource.Play();
        }
    }
}
