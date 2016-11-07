using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneMain1 : MonoBehaviour {
	[SerializeField]
	private AudioClip[] voix;
	[SerializeField]
	private AudioSource source;
	private string[] subttle;

	public bool Tuyauxpris;
	//public GameObject text;
	public Text txt;

	public static SceneMain1 instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.
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
		subttle = new string[11]; 
		subttle[0] = "Aïe. Ca a dû faire mal … Tout va bien ? Toi là bas dans l’ombre ? Tu m’entends ?";
		subttle[1] = "Tu es sûr? Bon, ça me rassure.  Ca me fait de la peine de te voir là, tout seul, coincé dans ces ténèbres.";
		subttle[2] = "Prisonnier par ces Fumerolles … mon pauvre … Les sales bêtes. ";
		subttle[3] = "Elles se jettent sur toi, te volent tes yeux et te laissent pourrir seul dans une cellule noire avant de …  ";
		subttle[4] = "Enfin bref. Tu n’avais peut-être pas besoin de ça. Désolé. Dis, j’ai une idée. Quoique … mmh.";
		subttle[5] = "Oui, ça peut peut-être marcher. Tu sais, j’aurais bien voulu venir t’aider directement mais  ";
		subttle[6] = "Tout ce que je peux faire dans ce trou à rat, c’est parler. Eh bien soit! Ecoute, à deux on peut te sortir de là.";
		subttle[7] = "Je serai les yeux qu’elles t’ont volées. Ca te va? Allez, courage, on peut le faire.  Je ne te laisserai pas tomber. Promis.";
		subttle[8] = "Tu vois le … euh non, pardon, l’habitude. Va plutôt sur la gauche, sous ton lit.  ";
		subttle[9] = "Tu devrais sentir un tuyau, non ? Arrache-le. N’ai pas peur, tout est ruiné par la rouille ici.";
		subttle[10] = "Parfait. La porte ne devrait pas tenir très longtemps. Vite, avant qu’elles reviennent!";

		InitPhase (0, 2);
		StartCoroutine (MyFunction(voix[0].length+voix[1].length+voix[2].length));
	
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
