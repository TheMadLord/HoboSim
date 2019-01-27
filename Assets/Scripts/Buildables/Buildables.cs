using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Buildables : MonoBehaviour
{
    public int cost;
    public Tile[] buildableOn;
    public float health;
    public int requiredRank;

    public virtual void Remove() {
        GameObject.Destroy(gameObject);
    }

    public virtual void damage(int amt)
    {
       health -= amt;
        if (health <= 0)
        {
            Remove();
        }
    }
}
