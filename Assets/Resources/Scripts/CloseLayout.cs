using UnityEngine;
using System.Collections;

public class CloseLayout : MonoBehaviour {

    BonusAdLayout b = new BonusAdLayout ();

    public void ExitLayout () {
        b.Initialize ();
        b.CloseBonus ();
    }


}
