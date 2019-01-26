using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {

    public  Transform enemyGameObject;

    public float timeBetween = 20f;
    private float countTime;

    private int waveNum = 0;

    public int numEnemies = 10;

    private bool waveEnded;

    public void Start() {
        countTime = timeBetween;
        waveEnded = true;
    }
	
	// Update is called once per frame
	void Update () {
        if(countTime <= 0f)
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

    IEnumerator SpawnWave()
    {
        waveNum++;

        for (int i = 0; i < numEnemies; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
        waveEnded = true;
    }

    void SpawnEnemy()
    {
        Instantiate(enemyGameObject, transform.position, transform.rotation);
    }
}
