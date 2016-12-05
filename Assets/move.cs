using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	Vector2 dest = Vector2.zero;
	public float speed = 0.1f;


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
			if (Input.GetKey(KeyCode.RightArrow))
				dest = (Vector2)transform.position + Vector2.right;
            if (Input.GetKey(KeyCode.LeftArrow))
                dest = (Vector2)transform.position - Vector2.right;

        }
			

		if ((Vector2)transform.position == dest) {
            speed = 0.03f;
			if (Input.GetKey(KeyCode.UpArrow))
				dest = (Vector2)transform.position + Vector2.up;
			if (Input.GetKey(KeyCode.DownArrow))
				dest = (Vector2)transform.position - Vector2.up;
		}
		/*if ((Vector2)transform.position == dest) {
            speed = 0.03f;
			if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
				dest = (Vector2)transform.position + (Vector2.right + Vector2.up);
			if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
				dest = (Vector2)transform.position - (Vector2.right + Vector2.up);
		}*/


    }

}