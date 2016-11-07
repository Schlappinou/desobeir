using UnityEngine;
using System.Collections;

public class SolQuiTombe : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

        GetComponent<Rigidbody2D>().gravityScale = 0;
        GetComponent<Rigidbody2D>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            Invoke("Fall", 1f);
        }

    }
    IEnumerator Falling()
    {
        for (float i = 20f; i >= 0; i -= 0.1f)
        {
            this.transform.position += new Vector3(0, -0.1f, 0);
            yield return new WaitForSecondsRealtime(0.01f);
        }
    }
    void Fall()
    {
        if (SceneMain.instance.Tuyauxpris)
        {
            StartCoroutine(Falling());
            //GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }


}
