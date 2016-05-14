using UnityEngine;
using System.Collections;

public class EndGameFeedback : MonoBehaviour {

    public AudioClip wood;
    AudioSource audio;
    int a;
	// Use this for initialization
	void Start () {
        a = 0;
        audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	    if (a == 0 && ((SetNuts.life <= 0) || (SetNuts.countdown <= 0))) {
            audio.PlayOneShot (wood);
            a++;
        }
	}
}
