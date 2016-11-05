using UnityEngine;
using System.Collections;

public abstract class Interactible : MonoBehaviour {

    // Use this for initialization
    protected bool interactionPossible;
    protected Color initColor;
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.GetComponent<PlayerController>() != null)
        {
            interactionPossible = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            interactionPossible = false;
        }
    }
    protected void couleurInteractionPossible(bool estPossible)
    {
        if (estPossible)
        {
            GetComponent<SpriteRenderer>().color = Color.HSVToRGB(0, 100, 100); //red
        }
        else
        {
            GetComponent<SpriteRenderer>().color = initColor;
        }
    }





}
