using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisablePlayButton : MonoBehaviour {

    Image a;
    
	// Use this for initialization
	void Start () {
        a = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
	    if (SetNuts.life <= 0 || SetNuts.countdown <= 0) {
            if (SetNuts.score < SetNuts.oneStar) {
                a.enabled = true;
            }
            else {
                a.enabled = false;
            }
        }
	}
}
