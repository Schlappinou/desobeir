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

    public void onTriggerEnter2D(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            Debug.Log("colliiisipfisujfio");
            interactionPossible = true;
        }
    }

    public void onTriggerExit2D(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            interactionPossible = false;
        }
    }

    



}
