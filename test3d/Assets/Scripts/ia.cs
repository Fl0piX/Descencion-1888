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

    bool move = true;

    float timerDamages;
    float timerLife;
    float timerMove;
    public float timerMaxDamages;
    public float timerMaxLife;
    public float timerMaxMove;

    //test de commit
    // Use this for initialization
    void Start () {
		dest = transform.position;
        timerDamages = 0;
        timerLife = 0;
        timerMove = 0;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Animator anim = GetComponent<Animator>();

        //déplacements
        if (Vector3.Distance(GameObject.Find("Gavrouche").transform.position, transform.position) >= 16 && move == true)
        {
            GameObject.Find("Garde").GetComponent<Animator>().SetBool("isFighting", true);
            speed = 0.5f;
            Vector3 p = Vector3.MoveTowards(transform.position, dest, speed);
            GetComponent<Rigidbody>().MovePosition(p);
            GameObject.Find("Garde").GetComponent<Animator>().SetFloat("Speed", speed);

            if (Vector3.Distance(dest, transform.position) < 16)
            {
                dest = GameObject.Find("Gavrouche").transform.position;
            }
        }
        else
        {
            speed = 0.0f;
            GameObject.Find("Garde").GetComponent<Animator>().SetFloat("Speed", speed);
        }



        if (Vector3.Distance(GameObject.Find("Gavrouche").transform.position, transform.position) < 16)
        {
            // donne un coup
            timerDamages += Time.deltaTime;
            if (timerDamages > timerMaxDamages)
            {
                timerDamages = 0;
                GameObject.Find("Gavrouche").GetComponent<Animator>().SetBool("takeDmg", true);

                fight();
            }

            // reçoit un coup
            if (GameObject.Find("Gavrouche").GetComponent<Animator>().GetBool("fighting") == true)
            {
                timerLife += Time.deltaTime;
                if (timerLife > timerMaxLife)
                {
                    timerLife = 0;
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
        //move = false;
        
        // L'ennemi ne bouge plus
        /*timerMove += Time.deltaTime;
        if (timerMove > timerMaxMove)
        {

            move = true;
            timerMove = 0;
        }*/
        // L'ennemi bouge

        GameObject.Find("Gavrouche").GetComponent<Animator>().SetBool("takeDmg", true);
        GameObject.Find("Garde").GetComponent<Animator>().SetBool("isFighting", true);



        //GameObject.Find("Gavrouche").GetComponent<Player>().enable = false;
    }
}