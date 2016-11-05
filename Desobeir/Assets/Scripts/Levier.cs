using UnityEngine;
using System.Collections;

public class Levier : Interactible {

    [SerializeField]
    float obeissance;

	// Use this for initialization
	void Start () {
        initColor = GetComponent<SpriteRenderer>().color;
        GameManager.instance.addJauge(-obeissance/2);
    }
	
	// Update is called once per frame
	void Update () {
        couleurInteractionPossible(interactionPossible);
	}

    void Interaction()
    {
        GameManager.instance.addJauge(obeissance);
    }
}
