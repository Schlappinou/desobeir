using UnityEngine;
using System.Collections;

public abstract class InteractibleDoor : Interactible {

    [SerializeField]
    protected string nextScene;
    [SerializeField]
    protected Color initColor;
    [SerializeField]
    protected float interactionRadius;
    // Use this for initialization
    void Start () {
        initColor = GetComponent<SpriteRenderer>().color;
        GetComponent<CircleCollider2D>().radius = interactionRadius;
    }
	
	// Update is called once per frame
	void Update () {
        couleurInteractionPossible(interactionPossible);
    }

    protected void couleurInteractionPossible(bool estPossible)
    {
        if (estPossible)
        {
            GetComponent<SpriteRenderer>().color = Color.HSVToRGB(0, 100, 100); //red color
        }
        else
        {
            GetComponent<SpriteRenderer>().color = initColor;
        }
    }
}
