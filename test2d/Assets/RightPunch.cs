using UnityEngine;
using System.Collections;

public class RightPunch : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        Animator anim = GetComponent<Animator>();
        if (Input.GetKey(KeyCode.Q))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Right") || anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                anim.Play("Right Punch");
            }

            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Left") || anim.GetCurrentAnimatorStateInfo(0).IsName("idleleft"))
            {
                anim.Play("Left Punch");
            }
        }

        if (Input.GetKey(KeyCode.S))
        {

            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Right") || anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                anim.Play("rightkick");
            }

            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Left") || anim.GetCurrentAnimatorStateInfo(0).IsName("idleleft"))
            {
                anim.Play("leftkick");
            }
        }
    }
}
