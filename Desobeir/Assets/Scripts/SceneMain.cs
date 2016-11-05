using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneMain : MonoBehaviour {
	[SerializeField]
	private AudioSource[] voix;

	private string[] subttle;
	//public GameObject text;
	public Text txt;

	public static SceneMain instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.
	void Awake()
	{
		//Check if instance already exists
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);

		//Sets this to not be destroyed when reloading scene
		// use full to keep it until the end of the game.
	
	}
	// Use this for initialization
	void Start () {
//s		txt = text.GetComponent<Text>();

		subttle = new string[voix.Length]; 
		subttle[0] = "C'est super ! ";
		//Debug.Log ("Je passe la t");
		ReadVoice (0);
	}
	void ReadVoice(int i){
		float time = voix[i].clip.length;
		StartCoroutine(readText(5.0F,i));
		//Debug.Log ("Je passe la r");

		voix [i].Play ();
	}
	IEnumerator readText(float time, int i){ 
		while ((time - Time.deltaTime)>0) {
			if (txt != null) {
				txt.text = subttle [i];
			}
			if (Input.GetKey (KeyCode.RightShift)) {
				if (voix.Length < i) {
					ReadVoice (i + 1);
				} else
					txt.text = "t'es cassé";
				yield break;
			}
			yield return new WaitForSeconds (.1f);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
