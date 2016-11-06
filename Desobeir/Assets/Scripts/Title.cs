using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

    Vector3 size;

	// Use this for initialization
	void Start () {
        size = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Return))
        {
            transform.localScale = new Vector3(size.x/(1.5f),size.y/ (1.5f), size.z);
            StartCoroutine(load());
        }
        else
        {
            transform.localScale = size;
        }
	}

    IEnumerator load()
    {
        
        yield return new WaitForSeconds(0.1f);

        SceneManager.LoadScene("LaChambre");


    }

}
