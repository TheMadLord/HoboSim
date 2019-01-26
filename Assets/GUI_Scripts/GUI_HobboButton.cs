using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_HobboButton : MonoBehaviour {

    public GameObject menu;

    void Start(){
    }

    void Update(){
    }

    public void toggleMenu(){
        menu.SetActive(!menu.activeSelf);
    }
}
