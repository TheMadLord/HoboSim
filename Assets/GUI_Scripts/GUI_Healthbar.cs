﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_Healthbar : MonoBehaviour {

    public float Health;
    protected float maxHealth;

	void Start () {
        Health = 100; maxHealth = 100;
	}
	
	void Update () {
        getHealth();
        Health = Health / maxHealth;
	}

    public float getHealth(){
        return (Health - .001f);
    }

}
