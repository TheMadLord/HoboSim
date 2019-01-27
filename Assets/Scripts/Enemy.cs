using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour {

    private int mHealth;
    private bool atTrash;
    private float mSpeed;
    private List<Transform> pointList;

    private Transform target;
    private int wavePointIndex = 0;

	// Use this for initialization
	void Start () {
        mHealth = 100;
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
        if (!MECH_MasterControls.GamePaused)
        {
            if (atTrash)
            {
                Vector3 direction = (EnemyTarget.pos - transform.position).normalized;
                transform.position += direction * Time.deltaTime * mSpeed;

                if ((EnemyTarget.pos - transform.position).magnitude < 2.7f)
                {
                    DiggingScript.HurtTrash(10);
                    damage(mHealth,false);
                }
            }
            else
            {
                Vector3 direction = (target.position - transform.position).normalized;
                transform.position += direction * Time.deltaTime * mSpeed;

                if (Vector3.Distance(target.position, transform.position) < 0.5f)
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

    void OnCollisionEnter2D(Collision2D col)
    {
        //print("hit");
        print(col.gameObject.name);
        if (col.gameObject.name == "CardBoardBox(Clone)")
        {
            //print("hit");
            //col.damage(10);
            col.gameObject.GetComponent<BoxLiving>().damage(10);
        }
        else if (col.gameObject.name == "AutoDigger(Clone)")
        {
            col.gameObject.GetComponent<AutoDigger>().damage(10);
        }
        /*
        else if (col.gameObject.name == "Player")
        {
            col.gameObject.GetComponent<Health>().damage(2);
        }
        */
    }

    public void damage(int amt, bool addSkillPoint = true)
    {
        mHealth -= amt;
        if(mHealth <= 0)
        {
            MECH_SkillPoints.SkillPoints += addSkillPoint? 1:0;
            Destroy(gameObject);
        }
    }
}
