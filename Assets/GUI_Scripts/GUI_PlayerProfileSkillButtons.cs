using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_PlayerProfileSkillButtons : MonoBehaviour {


    public string textSource;
    public Image imageSource;
    public GUI_PlayerProfileReadMoretab target;
    public int ID;
    public bool isSkillActive;
    protected bool isSkillUsed;
    protected int Cost;

    void Start() {
        Button b = GetComponent<Button>();
        imageSource = b.image;

        b.onClick.AddListener(() =>
        {
            target.SetText(textSource, imageSource, ID);
        });

        b.onClick.AddListener(() =>
        {
            if (!isSkillUsed)
            {
                switch (ID)
                {
                    case 300:
                        if (MECH_SkillPoints.SkillPoints - Cost > 0)
                        {
                            MECH_SkillPoints.SkillPoints -= Cost;
                            MECH_SkillPoints.trashCarryWeight++;
                            isSkillUsed = true;
                        }
                        break;
                    case 301:
                        if (MECH_SkillPoints.SkillPoints - Cost > 0)
                        {
                            MECH_SkillPoints.SkillPoints -= Cost;
                            MECH_SkillPoints.trashCarryWeight++;
                            isSkillUsed = true;
                        }
                        break;
                    case 302:
                        if (MECH_SkillPoints.SkillPoints - Cost > 0)
                        {
                            MECH_SkillPoints.SkillPoints -= Cost;
                            MECH_SkillPoints.trashCarryWeight++;
                            isSkillUsed = true;
                        }
                        break;
                    case 303:
                        if (MECH_SkillPoints.SkillPoints - Cost > 0)
                        {
                            MECH_SkillPoints.SkillPoints -= Cost;
                            MECH_SkillPoints.trashCarryWeight++;
                            isSkillUsed = true;
                        };
                        break;
                }
            }
        });
        imageSource.color = Color.black;
        Cost = (ID % 100) * 5;
        isSkillActive = false;
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
