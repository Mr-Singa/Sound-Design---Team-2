using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCollision : MonoBehaviour
{
    public PlaneMovement playerMove;
    public RandomSounds randomSound1;
    public RandomSounds randomSound2;

    public AudioSource source;
    public AudioSource winSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Player escasped");

            playerMove.enabled = false;
            randomSound1.enabled = false;
            randomSound2.enabled = false;

            source.volume = 0.2f;

            winSource.Play();
        }
    }
}
