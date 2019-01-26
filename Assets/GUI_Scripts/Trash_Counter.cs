using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trash_Counter : MonoBehaviour {

    protected int trash = 0;
    public Text trashText;

	void Start () {
	}

	void Update () {
        trashText.text = "TRASH : " + trash;	
	}
   
}
