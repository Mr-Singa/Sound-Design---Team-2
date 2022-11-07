using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Vector2 playerPos;
    float extraSpace = 1;

    public Vector2 girlfriendObj;

    void Start()
    {
        playerPos = transform.position;
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //TeleportGF();

        if (collision.tag == "Wall right")
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
    /*
    public void TeleportGF()
    {
        Vector2 gfLoc = girlfriendObj.transform.position;

        Vector2 distance = gfLoc - playerPos;

        Debug.Log(distance);

        girlfriendObj.transform.position - new Vector3(distance.x, distance.y, 0) = girlfriendObj.transform.position;
    }*/
}
