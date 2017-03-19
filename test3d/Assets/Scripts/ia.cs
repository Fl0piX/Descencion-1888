﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ia : MonoBehaviour {

	Vector3 dest = Vector3.zero;
	public float speed = 0.1f;
    public float damages;
    public float life;
    public float receivedDamages;

    float timerDamages;
    float timerLife;
    public float timerMaxDamages;
    public float timerMaxLife;
    float timerMove;
    float timerMaxMove;
    public float min;
    public float max;

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
        if (Vector3.Distance(GameObject.Find("Gavrouche").transform.position, transform.position) >= 16)
        {
            GameObject.Find("Garde").GetComponent<Animator>().SetBool("isFighting", false);
<<<<<<< HEAD

            // Après avoir mis ou reçu un coup, il s'arrête quelques secondes //
=======
            // Après avoir mis ou reçu un coup, il s'arrête quelques secondes
>>>>>>> 451a353602a86530a93f36342d4c2b2090367be1
            if (speed == 0.0f)
            {
                timerMove += Time.deltaTime;
                timerMaxMove = Random.value*(max-min)+min;
                if (timerMove > timerMaxMove)
                {
                    timerMove = 0;
                    speed = 0.5f;
                }
            }
            //                    //                    //                    //
            
            Vector3 p = Vector3.MoveTowards(transform.position, dest, speed);
            GetComponent<Rigidbody>().MovePosition(p);

            GameObject.Find("Garde").GetComponent<Animator>().SetFloat("Speed", speed);

            if (Vector3.Distance(dest, transform.position) < 16)
            {
                dest = GameObject.Find("Gavrouche").transform.position;
            }
        }
        else // Quand il touche Gavrouche
        {
            speed = 0.0f;
            GameObject.Find("Garde").GetComponent<Animator>().SetFloat("Speed", speed);

<<<<<<< HEAD
=======

        if (Vector3.Distance(GameObject.Find("Gavrouche").transform.position, transform.position) < 25)
        {
>>>>>>> 451a353602a86530a93f36342d4c2b2090367be1
            // donne un coup
            timerDamages += Time.deltaTime;
            if (timerDamages > timerMaxDamages)
            {
                timerDamages = 0;
                fight();

            }

            // reçoit un coup
            if (GameObject.Find("Gavrouche").GetComponent<Animator>().GetBool("fighting") == true)
            {
                if (GameObject.Find("Gavrouche").GetComponent<Animator>().GetBool("left") == false
                && GameObject.Find("Garde").GetComponent<Animator>().GetBool("right") == false
                || GameObject.Find("Gavrouche").GetComponent<Animator>().GetBool("left") == true
                && GameObject.Find("Garde").GetComponent<Animator>().GetBool("right") == true)
                {
                    timerLife += Time.deltaTime;
                    if (timerLife > timerMaxLife)
                    {
                        timerLife = 0;
                        life -= receivedDamages;
                    }

                    GameObject.Find("Garde").GetComponent<Animator>().SetBool("TakeDmg", true);
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
        StartCoroutine(oneHit());
        //GetComponent<healthbar>().setDamages(damages); // Gavrouche perd sa vie

        
        GameObject.Find("Gavrouche").GetComponent<Animator>().SetBool("takeDmg", true);
        
    }

    private IEnumerator oneHit()
    {
        GameObject.Find("Garde").GetComponent<Animator>().SetBool("isFighting", true);
        yield return new WaitForSeconds(0.2f);
        GetComponent<healthbar>().setDamages(damages);
        GameObject.Find("Garde").GetComponent<Animator>().SetBool("isFighting", false);
    }
}