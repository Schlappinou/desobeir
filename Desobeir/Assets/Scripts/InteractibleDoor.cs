using UnityEngine;
using System.Collections;

public abstract class InteractibleDoor : Interactible {

    [SerializeField]
    protected string nextScene;
   
    [SerializeField]
    protected float interactionRadius;
    // Use this for initialization
    void Start () {

        GetComponent<CircleCollider2D>().radius = interactionRadius;
    }
	
	// Update is called once per frame
	void Update () {

    }


}
