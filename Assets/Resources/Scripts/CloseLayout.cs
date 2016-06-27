using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CloseLayout : MonoBehaviour {

    BonusAdLayout b = new BonusAdLayout ();
    Animator rand;
    Animator bonus;
    GameObject g;
    GameObject gR;

    void Start () {
        gR = GameObject.Find ("Canvas/GameOverHUD/BONUSLAYOUT/Bonus");
        g = GameObject.Find ("Canvas/GameOverHUD/BONUSLAYOUT/BonusPowerUp");
        rand = g.GetComponent<Animator> ();
        bonus = gR.GetComponent<Animator> ();
    }

    public void ExitLayout () {
        g.GetComponent<Image> ().enabled = false;
        gR.GetComponent<Image> ().enabled = false;
        rand.SetBool ("canGo", false);
        bonus.SetBool ("GoOn", false);
       
        b.Initialize ();
        b.CloseBonus ();
    }


}
