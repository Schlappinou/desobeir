using UnityEngine;
using System.Collections;

public class Levier : Interactible {

    [SerializeField]
    float obeissance;
	[SerializeField]
	private GameObject nextObject;
	[SerializeField]
	private GameObject prevObject;
	[SerializeField]
	private TrompeOeil trompeOeil;

	// Use this for initialization
	void Start () {
      //  initColor = GetComponent<SpriteRenderer>().color;
        //GameManager.instance.addJauge(-obeissance/2);
    }
	
	// Update is called once per frame
	void Update () {
        //couleurInteractionPossible(interactionPossible);
	}

    public override void Interaction()
    {
		nextObject.SetActive (true);
		prevObject.SetActive (false);
		trompeOeil.triggered = true ;

    //    GameManager.instance.addJauge(obeissance);
    }
}
