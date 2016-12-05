using UnityEngine;
using System.Collections;

public class Walkleft : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Animator anim = GetComponent<Animator> ();
			if (null != anim) {
				anim.Play ("Left");
			}
		}
		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			Animator anim = GetComponent<Animator> ();
			if (null != anim) {
				anim.Play ("idleleft");
			}
		}
	}
}
