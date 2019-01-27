using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxLiving : MonoBehaviour {

    private int mHealth;
	// Use this for initialization
	void Start () {
        mHealth = 300;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void damage(int amt)
    {
        mHealth -= amt;
        if(mHealth <= 0)
        {
            Destroy(gameObject);
        }
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        //print("hit");
        //print(col.gameObject.name);
        if(col.gameObject.name == "Enemy(Clone)")
        {
            //print("hit");
            //damage(10);
        }
    }
}
