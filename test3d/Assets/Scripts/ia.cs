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
<<<<<<< HEAD
        
=======
>>>>>>> d58dbb4f616df5d7fad6ec637ef2aadfc2c633d3

        if ((Vector3)transform.position == dest) {
            
            dest = GameObject.Find("Gavrouche").transform.position;

        }

        /*if (Vector3.Distance(GameObject.FindGameObjectWithTag("Gavrouche").transform.position, transform.position) < 2)
        {
            
        }*/

    }
}
