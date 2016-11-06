using UnityEngine;
using System.Collections;

public class tableAI : MonoBehaviour {

    public SpriteRenderer rend;
    public float lampda;


    // Use this for initialization
    void Start()
    {
        if (rend == null)
        {
            rend = GetComponent<SpriteRenderer>();
        }
    }


    // Update is called once per frame
    void Update()
    {

        //Vector2 pl = instance.transform.position;
        //Vector2 mb = transform.position;
        Debug.Log(" perso :" + PlayerController.instance.transform.position.y + " mob :" + transform.position.y);
        Debug.Log(" perso :" + PlayerController.instance.transform.position.x + " mob :" + transform.position.x);

        //if (Vector2.Dot(PlayerController.instance.Y ,PlayerController.instance.transform.position) - Vector2.Dot(PlayerController.instance.Y, transform.position) > 0 )
        if (PlayerController.instance.transform.position.y > transform.position.y + lampda)
        {
            rend.sortingOrder = 5;
        }
        else
        {
            rend.sortingOrder = 3;
        }

    }
}
