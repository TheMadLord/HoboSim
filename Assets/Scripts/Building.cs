using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Tilemaps;

public class Building : MonoBehaviour
{
    public Buildables[] buildables;
    public int current = -1;
    public Tilemap tm;
    public Tile ground;
    public GameObject BuilderCollider;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(mouseRay, out hit, 500.0f))
            {
                if (current >= 0 && buildables[current].cost <= DiggingScript.Trash && hit.collider.tag != "Buildable")
                {
                    if (buildables[current].requiredRank == 0);
                    Vector3Int at = tm.WorldToCell(hit.point);
                    Tile clicked = (Tile)tm.GetTile(at);
                    if (buildables[current].buildableOn.Contains(clicked))
                    {
                        DiggingScript.SpendTrash(buildables[current].cost);
                        GameObject go = Instantiate(buildables[current], tm.CellToWorld(at) + new Vector3(0.5f, 0.5f), Quaternion.identity).gameObject;
                        Instantiate(BuilderCollider, go.transform);
                    }
                }
                else if (current == -2)
                {
                    if (hit.collider.tag == BuilderCollider.tag)
                    {
                        hit.transform.parent.GetComponent<Buildables>().Remove();
                    }
                }
            }

        }
        if (Input.GetMouseButtonDown(2))
        {
            current = -1;
        }
        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            current = -2;
        }
        for (int i = 0; i < buildables.Length; i++)
        {
            if (Input.GetKeyDown("" + (i + 1)))
            {
                current = i;
            }
        }
    }
}
