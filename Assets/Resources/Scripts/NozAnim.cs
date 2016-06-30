using UnityEngine;
using System.Collections;

public class NozAnim : MonoBehaviour {

    public float h, g, s;
    public bool b;

	// Update is called once per frame
	void Update () {
        Movement ();
	}

    void Movement () {
        if (b == true && this.transform.position.x > h) {
            gameObject.GetComponent<Rigidbody2D> ().gravityScale = g;
        }
        else {
            gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * s, ForceMode2D.Impulse);
            b = false;
        }
    }
}
