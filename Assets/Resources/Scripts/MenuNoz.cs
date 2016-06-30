using UnityEngine;
using System.Collections;

public class MenuNoz : MonoBehaviour {

    public float h, r, l;
    [SerializeField]
    bool g = true;

	void Update () {
        Movement (g);   
    }

    public void Movement (bool go) {
        if (go) {
            if (transform.position.y <= h) {
                transform.position = new Vector2 (transform.position.x, h);
            }
            if (transform.position.x <= l) {
                transform.position = new Vector2 (l, transform.position.y);
            }
            if (transform.position.x >= r) {
                transform.position = new Vector2 (r, transform.position.y);
            }
        }
    }

    void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.tag == "Noz") {
            gameObject.GetComponent<Rigidbody2D> ().isKinematic = true;
            g = false;
        }
    }
}
