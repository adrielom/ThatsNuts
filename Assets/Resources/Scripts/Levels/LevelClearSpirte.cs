using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelClearSpirte : MonoBehaviour {


    public Sprite[] spriteLevel;

	void Start () {
        GetComponent<Image> ().sprite = spriteLevel [SetNuts.levels - 1];
	}

}
