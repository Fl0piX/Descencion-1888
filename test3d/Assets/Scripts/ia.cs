using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ia : MonoBehaviour {

	Vector3 dest = Vector3.zero;
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
            GetComponent<Rigidbody>().MovePosition(p);

        }

        /*if (Vector3.Distance(GameObject.FindGameObjectWithTag("Gavrouche").transform.position, transform.position) < 2)
        {
            
        }*/

    }
}
