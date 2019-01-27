using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class DiggingScript : MonoBehaviour {
    public static int Trash{get; private set;}
    public static float heath { get; private set; }
    public static int MaxTrash;
    public Tilemap tm;
	// Use this for initialization
	void Awake () {
        Trash = 50;
        heath = 100;
        MaxTrash = 100;
	}

    public static void AddTrash(int amount) {
        Trash += amount;
        Trash = Mathf.Clamp(Trash, 0, MaxTrash);
    }

    public static bool SpendTrash(int amount) {
        if (amount > Trash) return false;
        Trash -= amount;
        return true;
    }

    public static void HurtTrash(float damage) {
        heath -= damage;
        print(heath);
        if (heath <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            string at = tm.GetTile(tm.WorldToCell(transform.position)).name;
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(mouseRay, out hit, 100.0f))
            {
                string clicked = tm.GetTile(tm.WorldToCell(hit.point)).name;
                if (at == "Digable" && clicked == "MagaTrash")
                {
                    ++Trash;
                }
            }
        }

	}
}
