using UnityEngine;
using System.Collections;

public class Bouton : Interactible {

    // Use this for initialization
    [SerializeField]
    int nombreAppuiPossible;
    [SerializeField]
    string nextScene;
    [SerializeField]
    bool hasNextScene;
    [SerializeField]
    float obeissance;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void Interaction()
    {
        if (nombreAppuiPossible >= 1)
        {
            GameManager.instance.addJauge(obeissance);
            nombreAppuiPossible -= 1;
        }
        else
        {
            if (hasNextScene)
            {
                GameManager.instance.sceneLoader(nextScene);
            }
        }
    }
}
