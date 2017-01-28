using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garde : MonoBehaviour {
    private GameObject Gavrouche;
    private Animator anim;
    // Use this for initialization
    void Start () {
        Gavrouche = GameObject.Find("Gavrouche");
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if ((transform.position.x) < (Gavrouche.transform.position.x))
        {
            anim.SetBool("right", true);
        }
        else
        {
            anim.SetBool("right", false);
        }
    }
}
