using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Vector2 playerPos;
    float extraSpace = 1;

    public GameObject girlfriendObj;

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
            playerPos.x = (transform.position.x * -1);

            gameObject.transform.position = new Vector3(playerPos.x + extraSpace, transform.position.y, 0);

            //TeleportGF();
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

        //TeleportGF();

    }

    public void TeleportGF()
    {
        Vector3 distance = new Vector3(this.gameObject.transform.position.x - girlfriendObj.transform.position.x,
            this.gameObject.transform.position.y - girlfriendObj.transform.position.y, 0);

        Debug.Log(distance);

        girlfriendObj.transform.position = this.gameObject.transform.position + distance;
    }
}
