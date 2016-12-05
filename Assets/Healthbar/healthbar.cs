using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class healthbar : MonoBehaviour {

    public GameObject healthBar;
    public Color Blue;
    public Color White;
    public Color Red;

    void Start()
    {
        setColor();
    }

    public void setDamages(float value)
    {
        healthBar.GetComponent<Scrollbar>().size -= value;

        float totalValue = healthBar.GetComponent<Scrollbar>().size;

        setColor(totalValue);
    }
	
    void setColor(float value = 1)
    {
        if (value >= 0.7f)
        {
            healthBar.transform.FindChild("Mask").FindChild("Sprite").GetComponent<Image>().color = Blue;
        }
        else if (value <= 0.7f && value >= 0.3f)
        {
            healthBar.transform.FindChild("Mask").FindChild("Sprite").GetComponent<Image>().color = White;
        }
        else
        {
            healthBar.transform.FindChild("Mask").FindChild("Sprite").GetComponent<Image>().color = Red;
        }
    }
}
