using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class Door : Interactible {

    // Use this for initialization
    [SerializeField]
    string nextScene;
    [SerializeField]
    Color initColor;
    [SerializeField]
    float interactionRadius;
    [SerializeField]
    bool obeissance;


    void Start () {
        initColor = GetComponent<SpriteRenderer>().color;
        GetComponent<CircleCollider2D>().radius = interactionRadius;
	}
	
	// Update is called once per frame
	void Update () {

        couleurInteractionPossible(interactionPossible);

    }

    public override void Interaction()
    {
        //GameManager.aObei(obeissance);
        //GameManager.sceneloader(nextScene);
    }

 

    void couleurInteractionPossible(bool estPossible)
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
