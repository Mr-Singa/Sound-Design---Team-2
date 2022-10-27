using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayerSounds : MonoBehaviour
{
    public AudioSource audioPlayer;
    public AudioClip footstepsNormal;
    public AudioClip footstepsPuddle;
    public AudioClip panting;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            audioPlayer.clip = footstepsNormal;
            if (audioPlayer.isPlaying == false)
                audioPlayer.Play();
        }
        else
        {
            audioPlayer.Stop();
        }

    }
}
