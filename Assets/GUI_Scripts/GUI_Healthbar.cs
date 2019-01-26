using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_Healthbar : MonoBehaviour {

    public float Health;
    protected float maxHealth;
    protected Image image;
	void Start () {
        Health = 100f; maxHealth = 100f;
        image = GetComponent<Image>();
	}
	
	void Update () {
        Health = getHealth();
        image.fillAmount = Health / maxHealth;
	}

    public float getHealth(){
        return (Health - .01f);
    }

}
