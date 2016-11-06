using UnityEngine;
using System.Collections;

public class SimpleDoor : InteractibleDoor {

	// Use this for initialization
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
        GameManager.instance.sceneLoader(nextScene);
    }
}
