using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneMain4 : MonoBehaviour {

	[SerializeField]
	private AudioClip[] voix;
	[SerializeField]
	private AudioSource source;
	private string[] subttle;

	public bool Tuyauxpris;
	//public GameObject text;
	public Text txt;

	public static SceneMain4 instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.
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
		subttle = new string[6]; 
		subttle[0] = "La voie est libre! Eh bien, c’en est presque insolent.";
		subttle[1] = "Si je me souviens bien, il y a une sortie juste au bout du couloir. J’espère qu’ils ne l’ont pas condamnée …  Longe bien à droite!";
		subttle[2] = "Ah. Evidemment, il fallait qu’elle soit condamnée …  ";
		subttle[3] = "Enfin c’est mieux que de tomber sur des Fumerolles. ";
		subttle[4] = "Tu vois les deux petites portes? Ca fera l’affaire. Tiens, prends … disons, ";
		subttle[5] = "celle de gauche. Pendant ce temps, j’essaye de te trouver un autre chemin.";
	//	subttle[4] = "C’est bon! Je t’en prie. On devrait être tranquille avant qu’elles ne reviennent.";
		InitPhase (0, 5);
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
