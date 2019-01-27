using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class shooting : MonoBehaviour {

    public Transform playerObject;
    public Transform attackGameObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 cursorInWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursorInWorldPos.z = playerObject.position.z;

        if (Input.GetMouseButtonDown(0))
        {
            fire((cursorInWorldPos - playerObject.position).normalized);
        }
    }

    public void fire(Vector3 vec)
    {
        print(vec.magnitude);
        GameObject go = Instantiate(attackGameObject, transform.position + (vec * 1), transform.rotation).gameObject;
        //go.GetComponent<NavMeshAgent>().SetDestination(new Vector3(10, 1, 10));
        go.GetComponent<Attack>().initTime(0, vec);
    }
}
