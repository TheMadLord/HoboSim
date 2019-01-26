using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Tilemaps;

public class Building : MonoBehaviour {
    public Buildables[] buildables;
    public int current = -1;
    public Tilemap tm;
    public Tile ground;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (current >= 0 && buildables[current].cost <= DiggingScript.Trash )
            {
                Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(mouseRay, out hit, 100.0f))
                {
                    Vector3Int at = tm.WorldToCell(hit.point);
                    Tile clicked = (Tile)tm.GetTile(at);
                    if (buildables[current].buildableOn.Contains(clicked))
                    {
                        tm.SetTile(at, buildables[current].tile);
                        DiggingScript.Trash -= buildables[current].cost;
                        print("Trash: " + DiggingScript.Trash);
                    }
                }
            }
            else if(current == -2)
            {
                Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(mouseRay, out hit, 100.0f))
                {
                    Vector3Int at = tm.WorldToCell(hit.point);
                    string clicked = tm.GetTile(at).name;
                    foreach(Buildables b in buildables) {
                        if (clicked == b.tile.name) {
                            tm.SetTile(at, ground);
                            DiggingScript.Trash += b.cost/2;
                            print("Trash: " + DiggingScript.Trash);
                        }
                    }
                }
            }
        }
        if (Input.GetMouseButtonDown(2))
        {
            current = -1;
        }
        if (Input.GetKeyDown(KeyCode.BackQuote)) {
            current = -2;
        }
        for (int i = 0; i < buildables.Length; i++) {
            if (Input.GetKeyDown("" + (i + 1)))
            {
                current = i;
            }
        }
    }
}
