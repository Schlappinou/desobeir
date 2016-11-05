using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public GameObject X00;
    public GameObject X10;
    public GameObject X01;

    Vector3 X;
    Vector3 Y;

    public float Speed;

    // Use this for initialization
    void Start () {
        X = X10.transform.position - X00.transform.position;
        Y = X01.transform.position - X00.transform.position;
        X = X.normalized;
        Y = Y.normalized;
    }
	
	// Update is called once per frame
	void Update () {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");

        transform.position += Speed * ( V * X +  -1 * H * Y) * Time.deltaTime;



    }
}
