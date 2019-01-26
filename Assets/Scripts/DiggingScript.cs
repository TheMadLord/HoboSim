using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DiggingScript : MonoBehaviour {
    public static int Trash = 100;
    public Tilemap tm;
	// Use this for initialization
	void Start () {
		
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
                    print(++Trash);
                }
            }
        }
	}
}
