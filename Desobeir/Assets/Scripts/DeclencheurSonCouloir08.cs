using UnityEngine;
using System.Collections;

public class DeclencheurSonCouloir08 : MonoBehaviour
{

    [SerializeField]
    int NumeroPisteSon;
    bool hasTriggered;
    // Use this for initialization
    void Start()
    {
        hasTriggered = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        

        if (!hasTriggered)
        {
            Debug.Log("trig");
            hasTriggered = true;
            if (!SceneMain.instance.Tuyauxpris)
            {
                Debug.Log("lancement piste son");
              //  SceneMain.instance.ReadVoice(NumeroPisteSon);
            }
        }
    }
}
