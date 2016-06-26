using UnityEngine;
using System.Collections;

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
        rand.enabled = false;
        bonus.enabled = false;
        b.Initialize ();
        b.CloseBonus ();

    }
    

}
