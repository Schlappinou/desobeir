﻿using UnityEngine;
using System.Collections;
using System;

public class InfiniteDoor : InteractibleDoor
{

    
    Vector3 initPosPlayer;
    // Use this for initialization
    void Start()
    {
        initColor = GetComponent<SpriteRenderer>().color;
        GetComponent<CircleCollider2D>().radius = interactionRadius;
        initPosPlayer = PlayerController.instance.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {

        couleurInteractionPossible(interactionPossible);

    }


    public override void  Interaction()
    {
        PlayerController.instance.transform.position = initPosPlayer;
    }


}
