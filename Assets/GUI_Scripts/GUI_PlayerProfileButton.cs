using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_PlayerProfileButton : MonoBehaviour {

    protected bool isMenuActive;
    public GameObject menu;
    public GameObject[] relatedObjs;

    void Start(){
    }

    void Update(){
    }

    public void toggleMenu(){
        menu.SetActive(!menu.activeSelf);
    }
}
