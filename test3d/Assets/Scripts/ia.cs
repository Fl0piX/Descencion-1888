using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ia : MonoBehaviour {

	Vector3 dest = Vector3.zero;
    GameObject Gavrouche = GameObject.Find("Gavrouche");
	public float speed = 0.1f;

    //test de commit
	// Use this for initialization
	void Start () {
		dest = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Animator anim = GetComponent<Animator>();

		Vector3 p = Vector3.MoveTowards(transform.position, dest, speed);
		GetComponent<Rigidbody>().MovePosition(p);
        dest = transform.position;

        if ((Vector3)transform.position == dest) {
            
            dest = GameObject.Find("Gavrouche").transform.position;

        }

        if ((transform.position.x) - (Gavrouche.transform.position.x) < 2)
        {
            anim.SetBool("fighting", true);
        }

    }
}
