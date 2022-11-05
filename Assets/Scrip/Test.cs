using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public AudioSource source;
    public AudioClip[] clips;

    public int clipMax;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("played clip");
            source.PlayOneShot(clips[Random.Range(0, clipMax)]);
        }
    }
}
