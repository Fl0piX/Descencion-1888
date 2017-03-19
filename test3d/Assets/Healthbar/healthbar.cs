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
        if (healthBar.GetComponent<Scrollbar>().size <= 0.1)
        {
<<<<<<< HEAD
            GameObject.Find("Gavrouche").GetComponent<Animator>().Play("Death"); // Quand Gavrouche meurt, retour au menu principal
            StartCoroutine(Death());
=======



            

            GameObject.Find("Gavrouche").GetComponent<Animator>().Play("Death"); // Quand Gavrouche meurt, retour au menu principal
            StartCoroutine(Death());
            

>>>>>>> f4544260e52546ec588a6ab126851f63cf8d86e4
        }
    }

    public void setDamages(float value)
    {
        healthBar.GetComponent<Scrollbar>().size -= value;
    }

    private IEnumerator Death()
    {        
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);        
    }
}
