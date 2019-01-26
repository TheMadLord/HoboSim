using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour {

    private int mHealth;
    public bool isAlive;
    private bool atTrash;
    private float mSpeed;
    private List<Transform> pointList;

    private Transform target;
    private int wavePointIndex = 0;

	// Use this for initialization
	void Start () {
        //sdadtransform.position = new Vector3(10, 1, 10);
        mHealth = 100;
        isAlive = true;
        mSpeed = 2.5f;

        target = pointList[0];
        atTrash = false;
    }

    public void initWaypoints(List<Transform> plist)
    {
        pointList = plist;
    }
	
	// Update is called once per frame
	void Update () {
        if (isAlive)
        {
            //print("djskbjvbsdljbl");
            //transform.position += new Vector3(0, 1) * Time.deltaTime;
            //Vector3 direction = (EnemyTarget.pos - transform.position).normalized;
            //transform.position += direction * Time.deltaTime * mSpeed;

            //if ((EnemyTarget.pos - transform.position).magnitude < 0.4f)
            //{
            //    damage(mHealth);
            //}
            //print(Vector3.Distance(target.position, transform.position));


            if (atTrash)
            {
                Vector3 direction = (EnemyTarget.pos - transform.position).normalized;
                transform.position += direction * Time.deltaTime * mSpeed;

                if ((EnemyTarget.pos - transform.position).magnitude < 2.7f)
                {
                    damage(mHealth);
                }
            }
            else
            {
                Vector3 direction = (target.position - transform.position).normalized;
                transform.position += direction * Time.deltaTime * mSpeed;

                if (Vector3.Distance(target.position, transform.position) < 0.2f)
                {
                    GetNextWaypoint();
                }
            }
            

        }
    }

    private void GetNextWaypoint()
    {
        wavePointIndex++;
        //print(wavePointIndex);
        if(wavePointIndex >= pointList.Count)
        {
            atTrash = true;
        }
        else
        {
            target = pointList[wavePointIndex];
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
