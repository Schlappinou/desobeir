using UnityEngine;
using System.Collections;
using System;

public class InfiniteDoor : InteractibleDoor
{

    GameObject player;
    Vector3 initPosPlayer;
    // Use this for initialization
    void Start()
    {
        initColor = GetComponent<SpriteRenderer>().color;
        GetComponent<CircleCollider2D>().radius = interactionRadius;
        player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            initPosPlayer = player.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {

        couleurInteractionPossible(interactionPossible);

    }


    public override void  Interaction()
    {
        player.transform.position = initPosPlayer;
    }


}
