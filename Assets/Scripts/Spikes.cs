using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : Buildables
{
    public List<Enemy> haveHit;
    public int maxHits = 5;
    public int damage = 25;

	void Start () {
        haveHit = new List<Enemy>();
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.name == "Enemy(Clone)") {
            Enemy e = col.gameObject.GetComponent<Enemy>();
            if (!haveHit.Contains(e))
            {
                e.damage(damage);
                haveHit.Add(e);
                if (haveHit.Count > 5)
                {
                    Destroy(gameObject);
                }
            }
            else {
                print("dsad");
            }
        }
    }
}
