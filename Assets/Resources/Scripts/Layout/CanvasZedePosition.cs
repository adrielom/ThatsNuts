using UnityEngine;
using System.Collections;

public class CanvasZedePosition : MonoBehaviour {

    RectTransform pos;

    void Start () {
        pos = GetComponent<RectTransform>();
    }

	void Update () {
        pos.localPosition = Vector3.zero;


    }
}
