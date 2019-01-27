using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_PlayerProfileReadMoretab : MonoBehaviour {

    public Text textFill;
    public Image IconImage;
    public static int ID;

    void Start() {
        gameObject.SetActive(false);
    }

    void Update() {
    }

    public void SetText(string t, Image i, int id) {
        if (ID  == id) {
            gameObject.SetActive(false);
            ID = 0000;
        }
        else
        {
            gameObject.SetActive(true);
            textFill.text = t;
            IconImage.sprite = i.sprite;
            ID = id;
        }
    }
}
