using UnityEngine;
using System.Collections;

public class CanvasZedePosition : MonoBehaviour {

    Vector3 pos;

    void Start () {
        pos = Vector3.zero;
    }

	void Update () {

        transform.position = pos;
	}
}
