using UnityEngine;

public class BgImage : MonoBehaviour {

	public Sprite[] bg;

	void Awake (){
		SettingSpritesBg ();
		
	}
	
	public void SettingSpritesBg (){

		if (SetNuts.levels == 1){

			gameObject.GetComponent<SpriteRenderer>().sprite = bg[0];
		}
		
		if (SetNuts.levels == 2){
			gameObject.GetComponent<SpriteRenderer>().sprite = bg[1];
		}
		
		if (SetNuts.levels == 3){
			gameObject.GetComponent<SpriteRenderer>().sprite = bg[2];
		}
		
		if (SetNuts.levels == 4){
			gameObject.GetComponent<SpriteRenderer>().sprite = bg[3];
		}
		
		if (SetNuts.levels == 5){
			gameObject.GetComponent<SpriteRenderer>().sprite = bg[4];
		}
		
		if (SetNuts.levels == 6){
			gameObject.GetComponent<SpriteRenderer>().sprite = bg[5];
		}
		
		if (SetNuts.levels == 7){
			gameObject.GetComponent<SpriteRenderer>().sprite = bg[6];
		}
		
		if (SetNuts.levels == 8){
			gameObject.GetComponent<SpriteRenderer>().sprite = bg[7];
		}
		
		if (SetNuts.levels == 9){
			gameObject.GetComponent<SpriteRenderer>().sprite = bg[8];
		}
		
		if (SetNuts.levels == 10){
			gameObject.GetComponent<SpriteRenderer>().sprite = bg[9];
		}

	}
}
