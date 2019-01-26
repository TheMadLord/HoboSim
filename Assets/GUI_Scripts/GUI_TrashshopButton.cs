using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_TrashshopButton : MonoBehaviour {

    public GameObject menu;
	
	void Start () {	
	}

	void Update () {	
	}

    public void ToggleMenu(){
        menu.SetActive(!menu.activeSelf);
    }
}
