using UnityEngine;
using System.Collections;

public class walkright : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Animator anim = GetComponent<Animator> ();
			if (null != anim) {
				anim.Play ("Right");
			}
		}
		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			Animator anim = GetComponent<Animator> ();
			if (null != anim) {
				anim.Play ("Idle");
			}
		}

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Animator anim = GetComponent<Animator> ();
			if (null != anim) {
				anim.Play ("Right");
			}
		}
		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			Animator anim = GetComponent<Animator> ();
			if (null != anim) {
				anim.Play ("Idle");
			}
		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Animator anim = GetComponent<Animator> ();
			if (null != anim) {
				anim.Play ("Right");
			}
		}
		if (Input.GetKeyUp (KeyCode.DownArrow)) {
			Animator anim = GetComponent<Animator> ();
			if (null != anim) {
				anim.Play ("Idle");
			}
		}
	}
}
