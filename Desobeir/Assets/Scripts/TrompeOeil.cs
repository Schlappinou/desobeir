using UnityEngine;
using System.Collections;

public class TrompeOeil : MonoBehaviour {

    public bool triggered;
	private Vector3 StartPos;
	[SerializeField]
	bool SalleLevier;
	[SerializeField]
	int NumPiste;
	// Use this for initialization
	void Start () {
		StartPos = PlayerController.instance.transform.position;
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
            if (!SalleLevier)
            {
                GameManager.instance.addJauge(10);
            }
            triggered = true;
			if (SalleLevier) {SceneMain.instance.ReadVoice (NumPiste);  
				PlayerController.instance.transform.position = StartPos;
			}
			else SceneMain.instance.ReadVoice (NumPiste);        }
    }

}
