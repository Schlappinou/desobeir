using UnityEngine;
using System.Collections;

public class DeclencheurSon : MonoBehaviour {

    [SerializeField]
    int NumeroPisteSon;
    bool hasTriggered;
	// Use this for initialization
	void Start () {
        hasTriggered = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (!hasTriggered)
        {
            hasTriggered = true;
            SceneMain.instance.ReadVoice(NumeroPisteSon);
        }
    }
}
