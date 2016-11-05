using UnityEngine;
using System.Collections;

public abstract class Interactible : MonoBehaviour {

    // Use this for initialization
    protected bool interactionPossible;
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void onTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            interactionPossible = true;
        }
    }

    public void onTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            interactionPossible = false;
        }
    }

    



}
