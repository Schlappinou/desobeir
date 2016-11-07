using UnityEngine;
using System.Collections;

public class RailCam : MonoBehaviour {
	Camera camera;
	public GameObject Player;
	public GameObject MaxPos;
	public GameObject MinPos;
	private Vector3 minPos;
	private Vector3 maxPos;
	private Vector3 Dir;
	private Vector3 CamPos;
	// Use this for initialization
	void Start () {
		camera = this.GetComponent<Camera> ();
		minPos = MinPos.transform.position;
		maxPos = MaxPos.transform.position;
		Dir = maxPos - minPos;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp2 = camera.transform.position;
		Vector3 temp = (Vector3.Project (Player.transform.position, Dir));
		camera.transform.position += (new Vector3 (temp.x, temp.y,camera.transform.position.z)-temp2) *10.0f*Time.deltaTime;
	}
}
