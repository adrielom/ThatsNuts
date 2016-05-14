using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour {

    [SerializeField] string IDAdds;

    void Awake () {
        Advertisement.Initialize (IDAdds, true);
	}
	
    public void ShowAd () {

        ShowOptions options = new ShowOptions ();
        options.resultCallback = AdCallbackHandler;

        if (Advertisement.IsReady("rewardedVideoZone")) {
            Advertisement.Show ("rewardedVideoZone", options);
        }
    }

    void AdCallbackHandler (ShowResult result) {

        switch (result) {
            case ShowResult.Finished:
                int a =  Random.Range (0, 3);
            if (a == 0)
                SetNuts.quantHammer++;
            else if (a == 1)
                SetNuts.quantClock++;
            else if (a == 2)
                SetNuts.quantSpdd++;
            break;

        }
    }
}
