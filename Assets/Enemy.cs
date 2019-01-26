using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private int mHealth;
    public bool isAlive;
    private float mSpeed;

	// Use this for initialization
	void Start () {
        //sdadtransform.position = new Vector3(10, 1, 10);
        mHealth = 100;
        isAlive = true;
        mSpeed = 5f;
	}
	
	// Update is called once per frame
	void Update () {
        if (isAlive)
        {
            //print("djskbjvbsdljbl");
            //transform.position += new Vector3(0,1) * Time.deltaTime;
            Vector3 direction = (EnemyTarget.pos - transform.position).normalized;
            transform.position += direction * Time.deltaTime * mSpeed;

            if((EnemyTarget.pos - transform.position).magnitude < 0.4f)
            {
                damage(mHealth);
            }
        }
	}

    public void damage(int amt)
    {
        mHealth -= amt;
        if(mHealth <= 0)
        {
            isAlive = false;
            Destroy(gameObject);
            
        }
    }
}
