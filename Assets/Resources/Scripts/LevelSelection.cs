using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour {


	public Sprite unlockedLevel;

	void Update (){
		SettingSprites ();

	}

	public void SettingSprites (){



		if (PlayerPrefs.GetInt ("lastLevel") >= 0 && this.gameObject.name == "level1"){
				GameObject g = GameObject.Find("level1");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
		}

		if (PlayerPrefs.GetInt ("lastLevel") >= 2 && this.gameObject.name == "level2"){
				GameObject g = GameObject.Find("level2");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

		if (PlayerPrefs.GetInt ("lastLevel") >= 3 && this.gameObject.name == "level3"){
				GameObject g = GameObject.Find("level3");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

		if (PlayerPrefs.GetInt ("lastLevel") >= 4 && this.gameObject.name == "level4"){
				GameObject g = GameObject.Find("level4");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

		if (PlayerPrefs.GetInt ("lastLevel") >= 5 && this.gameObject.name == "level5"){
				GameObject g = GameObject.Find("level5");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

		if (PlayerPrefs.GetInt ("lastLevel") >= 6 && this.gameObject.name == "level6"){
				GameObject g = GameObject.Find("level6");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

		if (PlayerPrefs.GetInt ("lastLevel") >= 7 && this.gameObject.name == "level7"){
				GameObject g = GameObject.Find("level7");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

		if (PlayerPrefs.GetInt ("lastLevel") >= 8 && this.gameObject.name == "level8"){
				GameObject g = GameObject.Find("level8");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

		if (PlayerPrefs.GetInt ("lastLevel") >= 9 && this.gameObject.name == "level9"){
				GameObject g = GameObject.Find("level9");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

		if (PlayerPrefs.GetInt ("lastLevel") >= 10 && this.gameObject.name == "level10"){
				GameObject g = GameObject.Find("level10");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

	}

	public void LoadLevel1 (){
        if (PlayerPrefs.GetInt ("lastLevel") >= 1 || SetNuts.levels >= 1) {
            SetNuts.levels = 1;
			Application.LoadLevel ("Jogo");
		}

	}
	public void LoadLevel2 (){
		if (PlayerPrefs.GetInt ("lastLevel") >= 2) {
			SetNuts.levels = 2;
			Application.LoadLevel ("Jogo");
		}
		
	}
	public void LoadLevel3 (){
		if (PlayerPrefs.GetInt ("lastLevel") >= 3) {
			SetNuts.levels = 3;
			Application.LoadLevel ("Jogo");
		}
		
	}
	public void LoadLevel4 (){
		if (PlayerPrefs.GetInt ("lastLevel") >= 4) {
            SetNuts.levels = 4;
            Application.LoadLevel ("Jogo");
		}
		
	}
	public void LoadLevel5 (){
		if (PlayerPrefs.GetInt ("lastLevel") >= 5) {
            SetNuts.levels = 5;
            Application.LoadLevel ("Jogo");
		}
		
	}
	public void LoadLevel6 (){
		if (PlayerPrefs.GetInt ("lastLevel") >= 6) {
            SetNuts.levels = 6; 
			Application.LoadLevel ("Jogo");
		}
		
	}
	public void LoadLevel7 (){
		if (PlayerPrefs.GetInt ("lastLevel") >= 7) {
            SetNuts.levels = 7;
            Application.LoadLevel ("Jogo");
		}
		
	}
	public void LoadLevel8 (){
		if (PlayerPrefs.GetInt ("lastLevel") >= 8) {
            SetNuts.levels = 8;
            Application.LoadLevel ("Jogo");
		}
		
	}
	public void LoadLevel9 (){
		if (PlayerPrefs.GetInt ("lastLevel") >= 9) {
            SetNuts.levels = 9;
            Application.LoadLevel ("Jogo");
		}
		
	}
	public void LoadLevel10 (){
		if (PlayerPrefs.GetInt ("lastLevel") >= 10) {
            SetNuts.levels = 10;
            Application.LoadLevel ("Jogo");
		}
		
	}


}
