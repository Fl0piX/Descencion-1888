using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthbar : MonoBehaviour {

    public GameObject healthBar;

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (healthBar.GetComponent<Scrollbar>().size <= 0)
        {
            SceneManager.LoadScene(0); // Quand Gavrouche meurt, retour au menu principal
        }
    }

    public void setDamages(float value)
    {
        healthBar.GetComponent<Scrollbar>().size -= value;
    }
}
