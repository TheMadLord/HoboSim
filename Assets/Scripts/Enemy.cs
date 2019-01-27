using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour {

    public int mHealth;
    private bool atTrash;
    private float mSpeed;
    private List<Transform> pointList;

    private Transform target;
    private int wavePointIndex = 0;

    public float attackSpeed = 0.5f;
    private float attackTimer;

	// Use this for initialization
	void Start () {
        mHealth = 100;
        mSpeed = 2.5f;

        target = pointList[0];
        atTrash = false;
        attackTimer = 0;
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
                    damage(mHealth);
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
            if (attackTimer > 0) {
                attackTimer -= Time.deltaTime;
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

    void OnCollisionStay2D(Collision2D col)
    {
        if (attackTimer <= 0) {
            if (col.gameObject.tag == "Buildable") {
                col.gameObject.GetComponent<Buildables>().damage(10);
                attackTimer = attackSpeed;
            }
        }
    }

    public void damage(int amt)
    {
        mHealth -= amt;
        if(mHealth <= 0)
        {
            MECH_SkillPoints.SkillPoints++;
            Destroy(gameObject);
        }
    }
}
