using UnityEngine;
using System.Collections;

public class SolQuiTombe : MonoBehaviour {

    int a;
	// Use this for initialization
	void Start () {
        a = 4;
        GetComponent<Rigidbody2D>().gravityScale = 0;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            Invoke("Fall", 0.5f);
        }
        
    }

    void Fall()
    {
        GetComponent<Rigidbody2D>().isKinematic = false;
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }


}
