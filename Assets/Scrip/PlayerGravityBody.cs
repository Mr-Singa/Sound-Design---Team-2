using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravityBody : MonoBehaviour
{
    public PlanetScript attractPlanet;
    private Transform playerTrans;

    void Start()
    {
        playerTrans = transform;
    }

    void Update()
    {
        if (attractPlanet)
        {
            attractPlanet.Attract(playerTrans);
        }
    }
}
