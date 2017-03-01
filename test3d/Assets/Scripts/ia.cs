using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ia : MonoBehaviour {

	Vector3 dest = Vector3.zero;
    //GameObject Gavrouche = GameObject.Find("Gavrouche");
	public float speed = 0.1f;
    public float damages;

    public float timer = 0;
    public float timerMax;

    //test de commit
	// Use this for initialization
	void Start () {
		dest = transform.position;
        timer = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Animator anim = GetComponent<Animator>();

		Vector3 p = Vector3.MoveTowards(transform.position, dest, speed);
		GetComponent<Rigidbody>().MovePosition(p);

        if (Vector3.Distance(dest, transform.position) < 20) {            
            dest = GameObject.Find("Gavrouche").transform.position;
        }

        timer += Time.deltaTime;
        if (timer > timerMax)
        {
            timer = 0;

            if (Vector3.Distance(GameObject.Find("Gavrouche").transform.position, transform.position) < 20)
            {
                anim.SetBool("fighting", true);

                fight();
                anim.SetBool("canhit", false);
            }
        }
        

    }

    void fight()
    {
        GetComponent<healthbar>().setDamages(damages);
    }
}
