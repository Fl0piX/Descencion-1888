using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ia : MonoBehaviour {

	Vector3 dest = Vector3.zero;
    //GameObject Gavrouche = GameObject.Find("Gavrouche");
	public float speed = 0.1f;
    public float damages;
    public float life;
    public float receivedDamages;

    float timerDamages;
    public float timerLife;
    public float timerMaxDamages;
    public float timerMaxLife;

    //test de commit
    // Use this for initialization
    void Start () {
		dest = transform.position;
        timerDamages = 0;
        timerLife = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Animator anim = GetComponent<Animator>();

        //déplacements

		Vector3 p = Vector3.MoveTowards(transform.position, dest, speed);
		GetComponent<Rigidbody>().MovePosition(p);

        if (Vector3.Distance(dest, transform.position) < 20) {            
            dest = GameObject.Find("Gavrouche").transform.position;
        }

        if (Vector3.Distance(GameObject.Find("Gavrouche").transform.position, transform.position) < 20)
        {
            // donne un coup
            timerDamages += Time.deltaTime;
            if (timerDamages > timerMaxDamages)
            {
                timerDamages = 0;
                fight();
                GameObject.Find("Gavrouche").GetComponent<Animator>().SetBool("takeDmg", false);
            }

            // reçoit un coup
            if (GameObject.Find("Gavrouche").GetComponent<Animator>().GetBool("fighting") == true)
            {
                timerLife += Time.deltaTime;
                if (timerLife > timerMaxLife)
                {
                    life -= receivedDamages;
                }
            }
        }

        //mort
        if (life <= 0)
        {
            GameObject.Find("Garde").SetActive(false);
        }
    }

    void fight()
    {
        GetComponent<healthbar>().setDamages(damages); // Gavrouche perd sa vie
        GameObject.Find("Gavrouche").GetComponent<Animator>().SetBool("takeDmg", true);
        //GameObject.Find("Gavrouche").GetComponent<Player>().enable = false;
    }
}