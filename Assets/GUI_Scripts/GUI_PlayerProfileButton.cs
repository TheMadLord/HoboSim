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
        isMenuActive = false;
        foreach (GameObject obj in relatedObjs)
        {
            if (obj.activeSelf)
            {
                isMenuActive = true;
                break;
            }
        }
    }

    public void toggleMenu(){
        if (!isMenuActive)
        {
            menu.SetActive(!menu.activeSelf);
        }
        
    }
}
