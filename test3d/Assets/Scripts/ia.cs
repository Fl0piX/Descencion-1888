using System.Collections;
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
    private Animator anim;
    public AudioClip punch;
    public AudioClip slap;
    public AudioClip ouch;
    AudioSource source;

    // Use this for initialization
    void Start () {
		dest = transform.position;
        anim = gameObject.GetComponent<Animator>();
        timerDamages = 0;
        timerLife = 0;
        timerMove = 0;
        source = gameObject.GetComponent<AudioSource>();
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Animator anim = GetComponent<Animator>();

        //déplacements
<<<<<<< HEAD
        if (Vector3.Distance(GameObject.Find("Gavrouche").transform.position, transform.position) >= 20)
=======
        if (Vector3.Distance(GameObject.Find("Gavrouche").transform.position, transform.position) >= 25 && Vector3.Distance(GameObject.Find("Gavrouche").transform.position, transform.position) < 100)
>>>>>>> a7abee80e51c051955bb6da9319a87cc1352e08d
        {
            anim.SetBool("isFighting", false);

            // Après avoir mis ou reçu un coup, il s'arrête quelques secondes //
            if (speed == 0.0f)
            {
                timerMove += Time.deltaTime;
                timerMaxMove = Random.value * (max - min) + min;
                if (timerMove > timerMaxMove)
                {
                    timerMove = 0;
                    speed = 0.5f;
                }
            }
            //                    //                    //                    //

            Vector3 p = Vector3.MoveTowards(transform.position, dest, speed);
            GetComponent<Rigidbody>().MovePosition(p);

            anim.SetFloat("Speed", speed);

            if (Vector3.Distance(dest, transform.position) < 20)
            {
                dest = GameObject.Find("Gavrouche").transform.position;
            }
        }
        else // Quand il touche Gavrouche
        {
            speed = 0.0f;
            anim.SetFloat("Speed", speed);

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
                && anim.GetBool("right") == false
                || GameObject.Find("Gavrouche").GetComponent<Animator>().GetBool("left") == true
                && anim.GetBool("right") == true)
                {
                    timerLife += Time.deltaTime;
                    if (timerLife > timerMaxLife)
                    {
                        timerLife = 0;
                        StartCoroutine(getHit());
                        life -= receivedDamages;
                    }
                }
            }
        }

        //mort
        if (life <= 0)
        {
            StartCoroutine(isDead());
        }
    }

    void fight()
    {
        source.PlayOneShot(punch, 1);
        StartCoroutine(oneHit());
        //GetComponent<healthbar>().setDamages(damages); // Gavrouche perd sa vie

        
        
    }

    private IEnumerator isDead()
    {
        anim.Play("dying");
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
    }


    private IEnumerator oneHit()
    {
        anim.SetBool("isFighting", true);
        GameObject.Find("Gavrouche").GetComponent<Animator>().SetBool("takeDmg", true);
        GameObject.Find("Gavrouche").GetComponent<Animator>().SetBool("fighting", false);
        yield return new WaitForSeconds(0.25f);
        source.PlayOneShot(ouch, 1);
        GetComponent<healthbar>().setDamages(damages);
        yield return new WaitForSeconds(0.25f);
        anim.SetBool("isFighting", false);
        GameObject.Find("Gavrouche").GetComponent<Animator>().SetBool("takeDmg", false);

    }

    private IEnumerator getHit()
    {
        anim.SetBool("TakeDmg", true);
        source.PlayOneShot(slap, 1);
        yield return new WaitForSeconds(1f);
        anim.SetBool("TakeDmg", false);

    }
}