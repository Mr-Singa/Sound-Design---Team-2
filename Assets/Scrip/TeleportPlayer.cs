using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Vector2 playerPos;
    float extraSpace = 1;

    void Start()
    {
        playerPos = transform.position;
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Wall right")
        {
            playerPos.x = (transform.position.x * -1);

            gameObject.transform.position = new Vector3(playerPos.x + extraSpace, transform.position.y, 0);
        }

        if (collision.tag == "Wall left")
        {
            playerPos.x = (transform.position.x * -1);

            gameObject.transform.position = new Vector3(playerPos.x - extraSpace, transform.position.y, 0);
        }

        if (collision.tag == "Wall top")
        {
            playerPos.y = (transform.position.y * -1);

            gameObject.transform.position = new Vector3(transform.position.x, playerPos.y + extraSpace, 0);
        }

        if (collision.tag == "Wall bottom")
        {
            playerPos.y = (transform.position.y * -1);

            gameObject.transform.position = new Vector3(transform.position.x, playerPos.y - extraSpace, 0);
        }

    }
}
