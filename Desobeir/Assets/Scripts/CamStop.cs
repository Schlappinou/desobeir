using UnityEngine;
using System.Collections;


public class CamStop : MonoBehaviour {
	public Camera cam;
	private RailCam Rc;
	// Use this for initializatio
	void Start () {
		Rc =cam.GetComponent<RailCam> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay2D(Collider2D other){
		Rc.enabled = false;
	}
}
