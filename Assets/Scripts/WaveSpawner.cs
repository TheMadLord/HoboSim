using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaveSpawner : MonoBehaviour {

    public Transform enemyGameObject;

    public float timeBetween = 10f;
    private float countTime;

    private int waveNum = 0;

    public int numEnemies = 3;

    private bool waveEnded;

    public Transform w1, w2, w3, w4, w5;
    public List<Transform> pointList;

    public void Start() {
        countTime = timeBetween;
        waveEnded = true;
        pointList.Add(w1);
        pointList.Add(w2);
        pointList.Add(w3);
        pointList.Add(w4);
        pointList.Add(w5);
    }
	
	// Update is called once per frame
	void Update () {
        if (!MECH_MasterControls.GamePaused)
        {
            if (countTime <= 0f)
            {
                waveEnded = false;
                StartCoroutine(SpawnWave());
                countTime = timeBetween;
            }

            if (waveEnded)
            {
                countTime -= Time.deltaTime;
            }
        }
	}

    IEnumerator SpawnWave()
    {
        waveNum++;

        for (int i = 0; i < numEnemies  * waveNum; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
        waveEnded = true;
    }

    void SpawnEnemy()
    {
        GameObject go = Instantiate(enemyGameObject, transform.position, transform.rotation).gameObject;
        //go.GetComponent<NavMeshAgent>().SetDestination(new Vector3(10, 1, 10));
        go.GetComponent<Enemy>().initWaypoints(pointList);
        go.GetComponent<Enemy>().initSprite((int)Random.Range(1, 3));
        //go.GetComponent<NavMeshAgent>().SetDestination(new Vector3(10, 1, 10));
    }
}
