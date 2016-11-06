using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class Door : InteractibleDoor {

    // Use this for initialization

    [SerializeField]
    float obeissance;


    void Start () {
        initColor = GetComponent<SpriteRenderer>().color;
        GetComponent<CircleCollider2D>().radius = interactionRadius;
	}
	
	// Update is called once per frame
	void Update () {

        couleurInteractionPossible(interactionPossible);

    }

    public override void Interaction()
    {
        GameManager.instance.addJauge(obeissance);
        GameManager.instance.sceneLoader(nextScene);
    }

 




}
