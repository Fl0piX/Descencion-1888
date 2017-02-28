using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {
	public void loadLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void quit()
    {
        Application.Quit();
    }

    public void son()
    {
        AudioSource music = GetComponent<AudioSource>();
        if (!music.isPlaying)
        {
            music.Play();
        }
        else
        {
            music.Stop();
        }
    }
}
