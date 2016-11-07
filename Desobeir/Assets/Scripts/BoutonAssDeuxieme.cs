using UnityEngine;
using System.Collections;

public class BoutonAssDeuxieme : Interactible
{

    // Use this for initialization
    [SerializeField]
    int nombreAppuiPossible;
    [SerializeField]
    int NumeroClipAudio;
    [SerializeField]
    string nextScene;
    [SerializeField]
    bool hasNextScene;
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
            GameManager.instance.addJauge(obeissance);
            nombreAppuiPossible -= 1;
            if (nombreAppuiPossible == 0)
            {
                Debug.Log("interaction faite");
                SceneMain.instance.ReadVoice (NumeroClipAudio);

            }
        }


        if (hasNextScene)
        {
            SceneMain.instance.Tuyauxpris = true;
            Invoke("StartNextScene",10f);
        }

    }

    void StartNextScene()
    {
        GameManager.instance.sceneLoader(nextScene);
    }
}
