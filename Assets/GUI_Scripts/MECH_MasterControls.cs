using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MECH_MasterControls : MonoBehaviour {

    public static bool GamePaused = false;
    public GameObject target;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (target.activeSelf)
        {
            MECH_MasterControls.GamePaused = true;
        }
        else
        {
            MECH_MasterControls.GamePaused = false;
        }
    }
}
