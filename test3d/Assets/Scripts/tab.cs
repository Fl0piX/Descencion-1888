using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tab : MonoBehaviour {
    Vector3 dest = Vector3.zero;
    public float speed = 0.5f;

    // Use this for initialization
    void Start () {
        dest = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 p = Vector3.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody>().MovePosition(p);

        if (Input.GetKey(KeyCode.RightArrow) ^ Input.GetKey(KeyCode.LeftArrow))
        {
            dest.x = GameObject.Find("Gavrouche").transform.position.x;
        }
    }
}
