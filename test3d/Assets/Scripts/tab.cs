using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tab : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Garde").activeSelf == false)
        {
            SceneManager.LoadScene(0);
            //GameObject.Find("Main Camera").transform.position = new Vector3 (300f, 40f, 138f); //GameObject.Find("Gavrouche").transform.position;
        }
    }
}
