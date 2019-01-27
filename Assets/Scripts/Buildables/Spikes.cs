using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : Buildables
{
    public int hitsRemaining = 5;
    public int mDamage = 10;
    public float attackTime = 0.5f;

    private float attackTimer = 0;

    public override void damage (int amt) {
        print(0);
    }

    public void Update()
    {
        if (!MECH_MasterControls.GamePaused)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.name == "Enemy(Clone)") {
            if (attackTimer == 0) { 
                Enemy e = col.gameObject.GetComponent<Enemy>();
                e.damage(mDamage);
                hitsRemaining--;
                if (hitsRemaining == 0) {
                    Remove();
                }
                attackTimer = attackTime;

            }
        }
    }
}
