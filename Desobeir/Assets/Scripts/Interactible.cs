using UnityEngine;
using System.Collections;

public abstract class Interactible : MonoBehaviour {

    // Use this for initialization
    float interactionRadius;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public abstract void Interaction();

    public abstract bool isInRange();



}
