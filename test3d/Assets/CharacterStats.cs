using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharacterStats : MonoBehaviour {

    public float health = 100;
    bool dealDamage;
    bool substractOnce;
    bool dead;

    public float damageTimer = .4f;
    WaitForSeconds damageT;

    Animator anim;

    public GameObject sliderPrefab;

    Slider healthSlider;
    RectTransform healthTrans;

	// Use this for initialization
	void Start () {
        damageT = new WaitForSeconds(damageTimer);
        anim = GetComponent<Animator>();

        GameObject slid = Instantiate(sliderPrefab, transform.position, Quaternion.identity) as GameObject;
        slid.transform.SetParent(GameObject.FindGameObjectsWithTag("Canvas").transform);
        healthSlider = slid.GetComponentInChildren<Slider>();
        healthTrans = slid.GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update () {
        healthSlider.value = health / 100;

        Vector2 screenPoint = RectTransformUtility.WorldToScreenPoint(Camera.main, transform.position);
        healthTrans.transform.position = screenPoint;

        if(dealDamage)
        {
            if(!substractOnce)
            {
                health -= 30;
                anim.SetTrigger("Hit");
                substractOnce = true;
            }

            StartCoroutine("CloseDamage");
        }
	}
}
