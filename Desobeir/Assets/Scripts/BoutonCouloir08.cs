using UnityEngine;
using System.Collections;

public class BoutonCouloir08 : Interactible
{

    // Use this for initialization
    [SerializeField]
    int nombreAppuiPossible;
    [SerializeField]
    int NumeroClipAudio;
    [SerializeField]
    float obeissance;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Interaction()
    {
        if (nombreAppuiPossible >= 1)
        {
            Debug.Log("bouton pression");
            GameManager.instance.addJauge(obeissance/nombreAppuiPossible);
            nombreAppuiPossible -= 1;
            if (nombreAppuiPossible == 0)
            {
                Debug.Log("interaction faite");
                SceneMain1.instance.ReadVoice (NumeroClipAudio, NumeroClipAudio);
                SceneMain.instance.Tuyauxpris = true;
            }
        }


    }
}
