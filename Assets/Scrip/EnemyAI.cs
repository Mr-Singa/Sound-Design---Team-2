using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float SPEED;
    public GameObject player;

    public float distance;
    public float chasingRange;
    public bool isChasing;

    public float walkPointRange;
    public Vector3 randomWalkPoint;
    float randomX, randomY;

    public AudioClip[] outroLossClips;

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
            Debug.Log("Player is cdead");
            
            //play outro loss
            
        }
    }
}
