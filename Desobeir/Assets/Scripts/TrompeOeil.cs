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
        if (!triggered)
        {
            triggered = false;
            //sceneManager.callNarrateur();
        }
    }

}
