using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPause : MonoBehaviour {


    private bool isPaused = false;
    private GameObject continuer;
    private GameObject healthbar;
    private GameObject confirmation;
    public Button Continuer;
    public Button MainMenu;
    public Button Quitter;
    public Button Oui;
    public Button Non;
    // Use this for initialization
    void Start () {

        confirmation = GameObject.Find("Confirmation");
        continuer = GameObject.Find("Interface");
        healthbar = GameObject.Find("Healthbar");
        Button resume = Continuer.GetComponent<Button>();
        Button menu = MainMenu.GetComponent<Button>();
        Button quit = Quitter.GetComponent<Button>();
        Button Yes = Oui.GetComponent<Button>();
        Button No = Non.GetComponent<Button>();
        menu.onClick.AddListener(menuPrincipal);
        resume.onClick.AddListener(stopPause);
        Yes.onClick.AddListener(quitGame);
        No.onClick.AddListener(noQuit);
        quit.onClick.AddListener(confirmationQuit);
        continuer.SetActive(false);
        confirmation.SetActive(false);

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

    void menuPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    void quitGame()
    {
        Application.Quit();
    }

    void noQuit()
    {
        confirmation.SetActive(false);
        continuer.SetActive(true);
    }

    void confirmationQuit()
    {
        continuer.SetActive(false);
        confirmation.SetActive(true);
    }
}
