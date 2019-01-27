using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_PlayerProfileSkillButtons : MonoBehaviour {
    
    public string textSource;
    public Image imageSource;
    public GUI_PlayerProfileReadMoretab target;
    public int ID;

	void Start () {
        Button b = GetComponent<Button>();
        imageSource = b.image;
        b.onClick.AddListener(() =>
        {
            target.SetText(textSource, imageSource, ID);
        });
	}

}
