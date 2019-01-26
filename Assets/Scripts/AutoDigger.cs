﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDigger : Buildables {
    public float timeBetweenDigs = 2;
    // Update is called once per frame
    private float timer;
    private int mHealth;
    void Start() {
        timer = timeBetweenDigs;
        mHealth = 100;
    }

	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0) {
            timer = timeBetweenDigs;
            DiggingScript.Trash += 1;
            //print("Trash :" + DiggingScript.Trash);
        }
	}

    public void damage(int amt)
    {
        mHealth -= amt;
        if(mHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
