using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Buildables : MonoBehaviour
{
    public int cost;
    public Tile[] buildableOn;
    public float heath;

    public void Damage(float amt) {
        heath -= amt;
        if (heath <= 0)
        {
            destroy();
        }
    }
    public void destroy() {
        GameObject.Destroy(gameObject);
    }
}
