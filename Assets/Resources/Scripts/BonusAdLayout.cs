using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BonusAdLayout {

    GameObject layout;

    public void Initialize () {
        layout = GameObject.Find ("BONUSLAYOUT");
        Debug.Log (layout);
        layout.SetActive (false);
    }
    	
	public void CloseBonus () {
        layout.SetActive (false);
	}

    public void CallBonus () {
        layout.SetActive (true);
    }
}
