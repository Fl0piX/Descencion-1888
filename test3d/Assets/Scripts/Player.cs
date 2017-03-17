using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float maxSpeed = 2.5f;
    public float xSpeed;
    public float zSpeed;
    public bool fighting;
    public bool left;

    private Rigidbody rb;
    private Animator anim;
    private GameObject rightPunch;
	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
        anim = gameObject.GetComponent<Animator>();
        //rightPunch = GameObject.Find("Right Punch");
        
	}
	
	// Update is called once per frame
	void Update () {
        

        if (Input.GetKey(KeyCode.LeftArrow) == true && Input.GetKey(KeyCode.RightArrow) == true)
        {
            anim.Play("idle");
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("left", true);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("left", false);
        }

        
        anim.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));
        anim.SetBool("fighting", fighting);

        if (Input.GetKey(KeyCode.UpArrow) == true && Input.GetKey(KeyCode.DownArrow) == true)
        {
            anim.Play("idle");
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetFloat("speed", Mathf.Abs(Input.GetAxis("Vertical")));
            anim.SetFloat("speed", 25);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            if (anim.GetBool("left") == false){
                anim.SetFloat("speed", 0);
                anim.SetBool("fighting", true);
                //rightPunch.GetComponent<BoxCollider>().isTrigger = false;
            }
            else
            {
                anim.SetFloat("speed", 0);
                anim.SetBool("fighting", true);
            }
        }
    }

    void FixedUpdate()
    {
        xSpeed = 800f;
        zSpeed = 100f;

        if (Input.GetKey(KeyCode.LeftArrow) == true && Input.GetKey(KeyCode.RightArrow) == true || (anim.GetBool("fighting") == true) || (Input.GetKey(KeyCode.UpArrow) == true && Input.GetKey(KeyCode.DownArrow) == true))
        {
            xSpeed = 0f;
            zSpeed = 0f;
        }

        /*if (Input.GetKey(KeyCode.UpArrow) == true && Input.GetKey(KeyCode.DownArrow) == true)
        {
            zSpeed = 0f;
        }*/

        float x = Input.GetAxis("Horizontal");

        rb.AddForce((Vector3.right * xSpeed) * x);
        if (Input.GetAxis("Vertical") != 0)
        {
            rb.transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * zSpeed * Time.deltaTime);

        }

        if (rb.velocity.x > maxSpeed)
        {
            rb.velocity = new Vector3(maxSpeed, rb.velocity.y);
        }

        if (rb.velocity.x < -maxSpeed)
        {
            rb.velocity = new Vector3(-maxSpeed, rb.velocity.y);
        }

        if (rb.velocity.y > maxSpeed)
        {
            rb.velocity = new Vector3(maxSpeed, rb.velocity.x);
        }

        if (rb.velocity.y < -maxSpeed)
        {
            rb.velocity = new Vector3(-maxSpeed, rb.velocity.x);
        }
        
    }
}
