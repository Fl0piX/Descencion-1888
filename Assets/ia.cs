using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ia : MonoBehaviour {

	Vector2 dest = Vector2.zero;
	public float speed = 0.1f;

    //test de commit
	// Use this for initialization
	void Start () {
		dest = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Animator anim = GetComponent<Animator>();

		Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
		GetComponent<Rigidbody2D>().MovePosition(p);
        

        if ((Vector2)transform.position == dest) {
            speed = 0.1f;
            dest = GameObject.FindGameObjectWithTag("Player").transform.position;
        }

        if (Vector2.Distance(GameObject.FindGameObjectWithTag("Player").transform.position, transform.position) < 2)
        {
            
        }

    }
}
