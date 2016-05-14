using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour {


	public Sprite unlockedLevel;

	void Update (){
		SettingSprites ();

	}

	public void SettingSprites (){



		if (SetNuts.levels >= 1 && this.gameObject.name == "level1"){
				GameObject g = GameObject.Find("level1");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
		}

		if (SetNuts.levels >= 2 && this.gameObject.name == "level2"){
				GameObject g = GameObject.Find("level2");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

		if (SetNuts.levels >= 3 && this.gameObject.name == "level3"){
				GameObject g = GameObject.Find("level3");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

		if (SetNuts.levels >= 4 && this.gameObject.name == "level4"){
				GameObject g = GameObject.Find("level4");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

		if (SetNuts.levels >= 5 && this.gameObject.name == "level5"){
				GameObject g = GameObject.Find("level5");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

		if (SetNuts.levels >= 6 && this.gameObject.name == "level6"){
				GameObject g = GameObject.Find("level6");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

		if (SetNuts.levels >= 7 && this.gameObject.name == "level7"){
				GameObject g = GameObject.Find("level7");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

		if (SetNuts.levels >= 8 && this.gameObject.name == "level8"){
				GameObject g = GameObject.Find("level8");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

		if (SetNuts.levels >= 9 && this.gameObject.name == "level9"){
				GameObject g = GameObject.Find("level9");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

		if (SetNuts.levels >= 10 && this.gameObject.name == "level10"){
				GameObject g = GameObject.Find("level10");
				g = this.gameObject;
				g.GetComponent<Image>().sprite = unlockedLevel;
			}

	}

	public void LoadLevel1 (){
		if (SetNuts.levels >= 1) {
			Application.LoadLevel ("Jogo");
		}

	}
	public void LoadLevel2 (){
		if (SetNuts.levels >= 2) {
			SetNuts.levels = PlayerPrefs.GetInt ("levels");
			Application.LoadLevel ("Jogo");
		}
		
	}
	public void LoadLevel3 (){
		if (SetNuts.levels >= 3) {
			SetNuts.levels = PlayerPrefs.GetInt ("levels");
			Application.LoadLevel ("Jogo");
		}
		
	}
	public void LoadLevel4 (){
		if (SetNuts.levels >= 4) {
			SetNuts.levels = PlayerPrefs.GetInt ("levels");
			Application.LoadLevel ("Jogo");
		}
		
	}
	public void LoadLevel5 (){
		if (SetNuts.levels >= 5) {
			SetNuts.levels = PlayerPrefs.GetInt ("levels");
			Application.LoadLevel ("Jogo");
		}
		
	}
	public void LoadLevel6 (){
		if (SetNuts.levels >= 6) {
			SetNuts.levels = PlayerPrefs.GetInt ("levels");
			Application.LoadLevel ("Jogo");
		}
		
	}
	public void LoadLevel7 (){
		if (SetNuts.levels >= 7) {
			SetNuts.levels = PlayerPrefs.GetInt ("levels");
			Application.LoadLevel ("Jogo");
		}
		
	}
	public void LoadLevel8 (){
		if (SetNuts.levels >= 8) {
			SetNuts.levels = PlayerPrefs.GetInt ("levels");
			Application.LoadLevel ("Jogo");
		}
		
	}
	public void LoadLevel9 (){
		if (SetNuts.levels >= 9) {
			SetNuts.levels = PlayerPrefs.GetInt ("levels");
			Application.LoadLevel ("Jogo");
		}
		
	}
	public void LoadLevel10 (){
		if (SetNuts.levels >= 10) {
			SetNuts.levels = PlayerPrefs.GetInt ("levels");
			Application.LoadLevel ("Jogo");
		}
		
	}


}
