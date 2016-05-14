using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour {

	//declaraçao de variaveis
    public static bool hammerTime = false;
	public static bool spddBool = false;
	public static bool clockBool = false;
	public GameObject pauseLayout;
	public new AudioSource audio;
	public Sprite audioButtonOn;
	public Sprite audioButtonOff;
	Sprite currentAudioImage;
	public AudioClip pause;
	public AudioClip menu;
	public AudioClip play;

	void Start (){
		pauseLayout.transform.position = new Vector3 (0f, 0f, -10000f);
	}

	void Update (){
		if (this.gameObject.name == "Audio"){
			this.gameObject.GetComponent<Button>().image.overrideSprite = currentAudioImage;
		}

	}

	//setta variavel pra verdadeiro
	public void Hammer()
    {
        hammerTime = true;  
    }
	//setta variavel pra verdadeiro
	public void Speed (){

		spddBool = true;

	}	
	//setta variavel pra verdadeiro
	public void Clock(){
		
		clockBool = true;

	}

	//pausa o jogo e traz o layout de pause pra frente da camera
	public void Pause(){
		pauseLayout.transform.position = new Vector3 (0f, 0f, 0f);
		audio.PlayOneShot (pause, 1f);
		Time.timeScale = 0;
	}

	//sai do pause e leva o layout de pause pra tras da camera
	public void ExitPause(){
		pauseLayout.transform.position = new Vector3 (0f, 0f, -10000f);
		audio.PlayOneShot (pause, 1f);
		Time.timeScale = 1;
	}

	public void Audio (){
		if (audio.enabled == true && this.gameObject.name == "Audio") {
			audio.enabled = false;
			currentAudioImage = audioButtonOff;
		} 
		else if (audio.enabled == false && this.gameObject.name == "Audio") {
			audio.enabled = true;
			currentAudioImage = audioButtonOn;
		}
	}

	public void LoadFirstGame (){
		audio.PlayOneShot (play, 1f);
		StartCoroutine (Delay("Jogo"));

		
		
	}

	//Vai pra cena do jogo e aumenta o level de dificuldade
	public void NextScene (){	
		SetNuts.levels++;
		PlayerPrefs.SetInt ("levels", SetNuts.levels);
		audio.PlayOneShot (play, 1f);
		StartCoroutine (Delay("Jogo"));
		pauseLayout.transform.position = new Vector3 (0f, 0f, -10000f);

	}

	//Vai pra cena do jogo no mesmo level de dificuldade
	public void SameScene (){
		SetNuts.levels = PlayerPrefs.GetInt ("levels");
		audio.PlayOneShot (play, 1f);
		StartCoroutine (Delay ("Jogo"));

	}

	//Sai do jogo
	public void Quit(){
		Application.Quit();
	}

	public void LevelSelectionScene (){
		audio.PlayOneShot (play, 1f);
		StartCoroutine (Delay("LevelSelection"));


	}

	//menu do jogo
	public void Menu(){
		audio.PlayOneShot (menu, 1f);
		StartCoroutine (Delay("Main"));

	}

	public void Social (){
		audio.PlayOneShot (play, 1f);
		StartCoroutine (Delay("Credits"));
	}

	IEnumerator Delay(string s){
		Time.timeScale = 1;
		yield return new WaitForSeconds (0.3f);
		Application.LoadLevel (s);

	}
}
