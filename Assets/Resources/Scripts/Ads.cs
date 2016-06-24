using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class Ads : MonoBehaviour {

    [SerializeField] string IDAdds;
    BonusAdLayout b = new BonusAdLayout ();

    Animator rand;
    Animator bonus;
    GameObject g;
    GameObject gR;
    public Sprite[] s;
    
    void Awake () {
        b.Initialize ();
        Advertisement.Initialize (IDAdds, true);
        gR = GameObject.Find ("Canvas/GameOverHUD/BONUSLAYOUT/Bonus");
        g = GameObject.Find ("Canvas/GameOverHUD/BONUSLAYOUT/BonusPowerUp");
        rand = g.GetComponent<Animator> ();
        bonus = gR.GetComponent<Animator> ();
        rand.enabled = true;
        bonus.enabled = true;
     
    }

    public void ShowAd () {
        rand.SetBool ("canGo", false);
        bonus.SetBool ("GoOn", false);
        ShowOptions options = new ShowOptions ();
        options.resultCallback = AdCallbackHandler;

        if (Advertisement.IsReady("rewardedVideoZone")) {
            Advertisement.Show ("rewardedVideoZone", options);
        }
    }

    void AdCallbackHandler (ShowResult result) {

        b.CallBonus ();
        bonus.SetBool ("GoOn", true);
        rand.SetBool ("canGo", true);

        switch (result) {
            case ShowResult.Finished:
                int a =  Random.Range (0, 3);
                if (a == 0) {
                    StartCoroutine (WaitAnimation (s[0]));
                    SetNuts.quantHammer++;
                }
                else if (a == 1) {
                    StartCoroutine (WaitAnimation (s[1]));
                    SetNuts.quantClock++;
                }
                else if (a == 2) {
                    StartCoroutine (WaitAnimation (s[2]));
                    SetNuts.quantSpdd++;
                }

            break;

        }
    }


    IEnumerator WaitAnimation (Sprite s) {
        yield return new WaitForSeconds (0.1f);
        g.gameObject.GetComponent<Image> ().sprite = s;

    }
}
