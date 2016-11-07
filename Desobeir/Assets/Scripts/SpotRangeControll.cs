using UnityEngine;
using System.Collections;

public class SpotRangeControll : MonoBehaviour {
	private float RangeValue;
	private GameManager GM;
	private Light li;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RangeValue = GameManager.instance.Jauge;
		this.GetComponent<Light> ().spotAngle = RangeValue;
	
	}
}
