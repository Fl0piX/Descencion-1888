using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {
	public void loadLevel()
    {
        SceneManager.LoadScene(1);
<<<<<<< HEAD
=======
    }

    public void quit()
    {
        Application.Quit();
    }

    public void playMusic()
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
>>>>>>> e4b5a1716397ac5a120e6247f17f3a4bf8ce10e5
    }
}
