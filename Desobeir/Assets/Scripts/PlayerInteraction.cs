using UnityEngine;
using System.Collections;

public class PlayerInteraction : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space))
        {	
            Interact();
        }
	}

    void Interact()
    {
       /* GameObject[] mesInteractibles = GameObject.FindGameObjectsWithTag("Interactible");
        int nbInteractibles = mesInteractibles.Length;
        bool interactibleFound = false;
        int i = 0;
        while ((!interactibleFound) && (nbInteractibles !=0) && (i < nbInteractibles))
        {
            Interactible myComponent = mesInteractibles[i].GetComponent<Interactible>();
            i++;
            if (myComponent != null)
            {
                if (myComponent.interactionPossible)
                {
                    interactibleFound = true;
					Debug.Log(myComponent.gameObject.transform.name + "interactible found");
                   
                    myComponent.Interaction();
                    
                    Debug.Log("interaction done");
                }
            }
        }*/
		
    }

}
