using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthbar : MonoBehaviour {

    public GameObject healthBar;
    float timerDeath;
    public float timerMaxDeath;
    float speed = 0.5f;
    
    void Start()
    {
        timerDeath = 0;
    }

    void FixedUpdate()
    {
        if (healthBar.GetComponent<Scrollbar>().size <= 0)
        {
            GameObject.Find("Garde").GetComponent<Animator>().Play("walk-right");
            Vector3 p = Vector3.MoveTowards(GameObject.Find("Garde").transform.position, new Vector3(94f, 40f, 134.8f), speed);
            GetComponent<Rigidbody>().MovePosition(p);

            timerDeath += Time.deltaTime;
            if (timerDeath > timerMaxDeath)
            {
                SceneManager.LoadScene(0); // Quand Gavrouche meurt, retour au menu principal
            }
        }
    }

    public void setDamages(float value)
    {
        healthBar.GetComponent<Scrollbar>().size -= value;
    }
}
