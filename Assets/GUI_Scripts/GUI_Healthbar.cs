using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using DiggingScript;

public class GUI_Healthbar : MonoBehaviour {

    public float Health;
    protected float maxHealth;
    protected Image image;

	void Start () {
        maxHealth = getHealth();
        Health = maxHealth;
        image = GetComponent<Image>();
	}
	
	void Update () {
        Health = getHealth();
        image.fillAmount = Health / maxHealth;
	}

    public float getHealth(){
        return (DiggingScript.heath);
    }

}
