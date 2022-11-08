using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public PlaneMovement playerMove;
    public RandomSounds randomSound1;
    public RandomSounds randomSound2;

    public float SPEED;
    public GameObject player;

    public float distance;
    public float chasingRange;
    public bool isChasing;

    public float walkPointRange;
    public Vector3 randomWalkPoint;
    float randomX, randomY;

    public AudioSource source;
    public AudioClip[] outroLossClips;

    public GameObject sound1;

    void Start()
    {

    }

    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);

        if(distance < chasingRange)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, SPEED * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(this.transform.position, randomWalkPoint, SPEED * Time.deltaTime);

            if (transform.position == randomWalkPoint)
            {
                randomX = Random.Range(-walkPointRange, walkPointRange);
                randomY = Random.Range(-walkPointRange, walkPointRange);

                randomWalkPoint = new Vector3(randomX, randomY, 0);
                Debug.Log(randomWalkPoint);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            playerMove.enabled = false;
            randomSound1.enabled = false;
            randomSound2.enabled = false;

            sound1.SetActive(false);

            source.Stop();

            StartCoroutine(EPlayOurto());
        }
    }

    public IEnumerator EPlayOurto()
    {
        source.volume = 1f;

        for (int i = 0; i < outroLossClips.Length; i++)
        {
            source.PlayOneShot(outroLossClips[i]);
            yield return new WaitForSeconds(outroLossClips[i].length);

            if(i == 1)
            {
                Debug.Log("game over");
            }
        }
    }
}
