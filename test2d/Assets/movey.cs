using UnityEngine;
using System.Collections;

public class movey : MonoBehaviour {

	Vector2 dest = Vector2.zero;
	public float speed = 0.03f;
	// Use this for initialization
	void Start () {
		dest = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
		GetComponent<Rigidbody2D>().MovePosition(p);

		if ((Vector2)transform.position == dest) {
			if (Input.GetKey(KeyCode.UpArrow))
				dest = (Vector2)transform.position + Vector2.up;
			if (Input.GetKey(KeyCode.DownArrow))
				dest = (Vector2)transform.position - Vector2.up;
		}
	}
}
