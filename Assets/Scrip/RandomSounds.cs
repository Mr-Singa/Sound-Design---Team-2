using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSounds : MonoBehaviour
{
    public AudioSource source;

    public AudioClip[] clips;

    public float timerMin, timerMax;

    void Start()
    {
        StartCoroutine(ERandomSounds());
    }

    public IEnumerator ERandomSounds()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(timerMin, timerMax));

            source.PlayOneShot(clips[Random.Range(0, clips.Length)]);
        }
    }
}
