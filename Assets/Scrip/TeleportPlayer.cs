using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Vector2 playerPos;

    void Start()
    {
        playerPos = transform.position;
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Wall X")
        {
            playerPos.x = transform.position.x * -1;

            gameObject.transform.position = new Vector3(playerPos.x, transform.position.y, 0);
        }

        if (collision.tag == "Wall Y")
        {
            playerPos.y = transform.position.y * -1;

            gameObject.transform.position = new Vector3(transform.position.x, playerPos.y, 0);
        }

    }
}
