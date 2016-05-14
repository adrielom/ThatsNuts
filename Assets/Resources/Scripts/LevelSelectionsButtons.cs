using UnityEngine;
using System.Collections;

public class LevelSelectionsButtons : MonoBehaviour {

	public AudioClip sound;
	public new AudioSource aud;

	void start (){
		aud = GetComponent<AudioSource> ();
	}

	public void Menu(){
		aud.PlayOneShot (sound, 0.5f);
		StartCoroutine (Delay("Main"));

	}
	
	public void Facebook (){
		Application.OpenURL ("https://www.facebook.com/HighFiveStudiosV");
	}

	public void Twitter (){
		Application.OpenURL ("https://twitter.com/HighFiveStudios");
	}

	public void Instagram (){
		Application.OpenURL ("https://www.instagram.com/highfivestudiosv/");
	}

	public void Site (){
		Application.OpenURL ("https://http://highfivestudios.com.br/");
	}

	IEnumerator Delay(string s){
		yield return new WaitForSeconds (0.4f);
		Application.LoadLevel (s);
	}
}
