using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    public float speed;
    public float meleeTTL, shortTTL, midTTL, gunTTL;
    private float myTime;
    private Vector3 moveVec;

	// Use this for initialization
	void Start () {
        meleeTTL = 0.5f;
        shortTTL = 1.3f;
        midTTL = 2.4f;
        gunTTL = 3.5f;

        speed = 5;
	}

    public void initTime(int type, Vector3 vec)
    {
        if (type == 0)
        {
            myTime = meleeTTL;
        }
        else if (type == 1)
        {
            myTime = shortTTL;
        }
        else if (type == 2)
        {
            myTime = midTTL;
        }
        else if(type == 3)
        {
            myTime = gunTTL;
        }

        moveVec = vec;
    }
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, myTime);

        transform.position += moveVec * Time.deltaTime * speed;
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        //print("hit");
        print(col.gameObject.name);
        if (col.gameObject.name == "Enemy(Clone)")
        {
            //print("hit");
            //col.damage(10);
            col.gameObject.GetComponent<Enemy>().damage(100);
        }
        Destroy(gameObject);
    }
}
