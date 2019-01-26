using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_LefthandMenu : MonoBehaviour {

    protected bool isMenuActive;
    public GameObject[] relatedObjs;
    public GameObject menu1;
    public GameObject menu2;
    
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
    public void ToggleMenu()
    {
        if (!isMenuActive)
        {
            menu1.SetActive(!menu1.activeSelf);
            menu2.SetActive(!menu2.activeSelf);
        }
    }
}
