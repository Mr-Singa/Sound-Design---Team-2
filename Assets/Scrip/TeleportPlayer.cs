using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Vector2 playerPos;
    float extraSpace = 1;

    public GameObject girlfriendObj;
    Vector3 distance;

    void Start()
    {
        playerPos = transform.position;
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Wall right")
        {
            TeleportGF();

            playerPos.x = (transform.position.x * -1);

            gameObject.transform.position = new Vector3(playerPos.x + extraSpace, transform.position.y, 0);

            girlfriendObj.transform.position = this.gameObject.transform.position + distance;

        }

        if (collision.tag == "Wall left")
        {
            TeleportGF();

            playerPos.x = (transform.position.x * -1);

            gameObject.transform.position = new Vector3(playerPos.x - extraSpace, transform.position.y, 0);

            girlfriendObj.transform.position = this.gameObject.transform.position + distance;
        }

        if (collision.tag == "Wall top")
        {
            TeleportGF();

            playerPos.y = (transform.position.y * -1);

            gameObject.transform.position = new Vector3(transform.position.x, playerPos.y + extraSpace, 0);

            girlfriendObj.transform.position = this.gameObject.transform.position + distance;
        }

        if (collision.tag == "Wall bottom")
        {
            TeleportGF();

            playerPos.y = (transform.position.y * -1);

            gameObject.transform.position = new Vector3(transform.position.x, playerPos.y - extraSpace, 0);

            girlfriendObj.transform.position = this.gameObject.transform.position + distance;
        }

    }

    public void TeleportGF()
    {
        distance = new Vector3(girlfriendObj.transform.position.x - this.gameObject.transform.position.x,
            girlfriendObj.transform.position.y - this.gameObject.transform.position.y, 0);

        Debug.Log(distance);
    }
}
