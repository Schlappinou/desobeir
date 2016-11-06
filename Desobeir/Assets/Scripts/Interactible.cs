using UnityEngine;
using System.Collections;

public abstract class Interactible : MonoBehaviour {

    // Use this for initialization
	[SerializeField]
	public bool interactionPossible =false;
    protected Color initColor;
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void OnTriggerStay2D(Collider2D other)
    {
		//Debug.Log ("Je rentrre dans le lit");
        if (other.GetComponent<PlayerController>() != null)
        {
			if (Input.GetKeyDown(KeyCode.Space)) {
				this.Interaction();
			}
            //interactionPossible = true;
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

    public abstract void Interaction();





}
