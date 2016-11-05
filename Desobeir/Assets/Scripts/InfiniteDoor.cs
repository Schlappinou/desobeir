using UnityEngine;
using System.Collections;
using System;

public class InfiniteDoor : InteractibleDoor {


    // Use this for initialization
    void Start () {
        initColor = GetComponent<SpriteRenderer>().color;
        GetComponent<CircleCollider2D>().radius = interactionRadius;
    }
	
	// Update is called once per frame
	void Update () {
	
	}


    public void Interaction(GameObject player)
    {
        //player.transform.position = sceneManager.playerInitPosition
    }


}
