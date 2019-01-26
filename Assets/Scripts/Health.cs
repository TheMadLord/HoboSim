using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    private int mHealth;

	// Use this for initialization
	void Start () {
        mHealth = 100;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void damage(int amt)
    {
        mHealth -= amt;
        if(mHealth <= 0)
        {
            print("GAME OVER -- PLAYER IS DEAD");
        }
    }
}
