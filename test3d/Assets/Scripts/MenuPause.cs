using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPause : MonoBehaviour {


    private bool isPaused = false;
    private GameObject continuer;
    private GameObject healthbar;
    public Button Continuer;
    // Use this for initialization
    void Start () {

        continuer = GameObject.Find("Continuer");
        healthbar = GameObject.Find("Healthbar");
        Button resume = Continuer.GetComponent<Button>();
        resume.onClick.AddListener(stopPause);

        continuer.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused == true)
        {
            
            Time.timeScale = 0.0f;
            
        }

        if (isPaused == false)
        {
            
            Time.timeScale = 1.0f;
        }

        if (Time.timeScale == 0.0f)
        {
            continuer.SetActive(true);
            healthbar.SetActive(false);
        }

        if (Time.timeScale == 1.0f)
        {
            continuer.SetActive(false);
            healthbar.SetActive(true);
        }
    }

    void stopPause()
    {
        isPaused = false;
    }
}
