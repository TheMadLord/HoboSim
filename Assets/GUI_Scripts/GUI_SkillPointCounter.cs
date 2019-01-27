using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_SkillPointCounter : MonoBehaviour {

    protected int SkillPoints = 0;
    public Text SkillPointsText;

    void Start()
    {
    }

    void Update()
    {
        SkillPointsText.text = "Skill Points : " + MECH_SkillPoints.SkillPoints;
    }

}
