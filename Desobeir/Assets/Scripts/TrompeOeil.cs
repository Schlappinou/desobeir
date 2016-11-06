using UnityEngine;
using System.Collections;

public class TrompeOeil : MonoBehaviour {

    bool triggered;
	// Use this for initialization
	void Start () {
        triggered = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
		//Debug.Log ("je passe");
        if (!triggered)
        {	

            triggered = false;
			SceneMain.instance.ReadVoice (3);        }
    }

}
