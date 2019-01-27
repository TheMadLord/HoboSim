using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_PlayerProfileSkillButtons : MonoBehaviour {


    public string textSource;
    public Image imageSource;
    public GUI_PlayerProfileReadMoretab target;
    public int ID;
    //public bool isSkillActive;
    public bool isSkillUsed;
    public int Cost;

    void Start() {
        Button b = GetComponent<Button>();
        imageSource = b.image;
        MECH_SkillPoints.Skills[ID] = this;

        b.onClick.AddListener(() =>
        {
            target.SetText(textSource, imageSource, ID);
        });
        
        imageSource.color = Color.black;
        Cost = (ID % 100) * 5;
        //isSkillActive = false;
        isSkillUsed = false;
    }

    void Update()
    {
        if (isSkillUsed)
        {
            imageSource.color = Color.white;
        }
    }
}
