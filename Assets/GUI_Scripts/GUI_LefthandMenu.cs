using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_LefthandMenu : MonoBehaviour {

    public GameObject menu1;
    public GameObject menu2;

    public void ToggleMenu()
    {
        menu1.SetActive(!menu1.activeSelf);
        menu2.SetActive(!menu2.activeSelf);
    }
}
