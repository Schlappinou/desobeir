using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneMain3b : MonoBehaviour {

	[SerializeField]
	private AudioClip[] voix;
	[SerializeField]
	private AudioSource source;
	private string[] subttle;

	public bool Tuyauxpris;
	//public GameObject text;
	public Text txt;

	public static SceneMain3b instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.
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
		Tuyauxpris =false;
		subttle = new string[4]; 
		subttle[0] = "Ah. Bon. Tu sais, si je t’ai dis « bouton de droite », ce n’était pas par hasard.";
		subttle[1] = "Il n’y a vraiment pas grand-chose ici. D’ailleurs tu as de la chance qu’il n’y ai surtout personne";
		subttle[2] = "Tu peux me faire confiance, tu sais! Si j’étais toi, je ferai attention. On ne sait jamais ce qui peut nous tomber dessus.On y retourne.";
		subttle[3] = "C’est vrai que c’est une bonne idée de se terrer dans ce sous-sol vide et inintéressant en attendant les Fumerolles ... Bon, on continue";
		//		subttle[4] = "C’est bon! Je t’en prie. On devrait être tranquille avant qu’elles ne reviennent.";
		InitPhase (0, 2);
		//StartCoroutine (MyFunction(voix[0].length+voix[1].length+voix[2].length));

		//Debug.Log ("Je passe la t");
		//	Debug.Log (voix.Length);
		//Debug.Log (voix [1].length);
	}
	public bool InitPhase(int i , int y) {
		return ReadVoice (i, y);

	}
	public bool ReadVoice(int i, int max){
		//voix [i].LoadAudioData ();
		//Debug.Log((voix [1]!=null));
		if (voix [i] != null) {
			//	source.Stop();
			source.clip = voix [i];
			Debug.Log (source.clip = voix [i]);
			float time = source.clip.length;
			Debug.Log (time);
			source.Play ();
			StartCoroutine (readText (time, i, max));
			if (i == max) {
				//StartCoroutine (readText (time, max, max));

				return true;
			}
			else{ return false;};
		}
		else return false;


	}
	IEnumerator readText(float time, int i, int max){ 
		if (txt != null) {
			txt.text = subttle [i];
		}			

		/* (Input.GetKeyDown (KeyCode.RightShift)) {
				if (voix.Length > i + 1) {
					ReadVoice (i + 1);
				} else {
					txt.text = "t'es cassé";
				}
				yield break;
			}*/

		yield return new WaitForSeconds (time);
		if (max+1 > i+1) {
			ReadVoice (i + 1,max);
		}
	}
	// Update is called once per frame
	void Update () {


	}
	IEnumerator MyFunction(float delayTime)
	{
		yield return new WaitForSeconds(delayTime);
		InitPhase (3, 9);
		// Now do your thing here
	}
}
