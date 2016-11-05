using UnityEngine;
using System.Collections;

public class DoorChambre : InteractibleDoor {

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
	{   if (SceneMain.instance.Tuyauxpris) {
			GameManager.instance.sceneLoader (nextScene);
		}
	}
}
