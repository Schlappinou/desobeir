using UnityEngine;
using System.Collections;

public class Bouton : Interactible {

    // Use this for initialization
    int nombreAppuiPossible;
    float obeissance;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Interaction()
    {
        if (nombreAppuiPossible >= 1)
        {
            GameManager.instance.addJauge(obeissance);
            nombreAppuiPossible--;
        }
    }
}
