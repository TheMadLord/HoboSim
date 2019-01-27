using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_PlayerProfilePurchaseButton : MonoBehaviour {

    public int ID;
    public Text PurchaseText;

	void Start () {
        gameObject.GetComponent<Button>().image.color = Color.white;
        gameObject.GetComponent<Button>().onClick.AddListener(() =>
        {
            GUI_PlayerProfileSkillButtons s = MECH_SkillPoints.Skills[ID];
            if (!s.isSkillUsed)
            {
                switch (ID)
                {
                    case 100:
                        if (MECH_SkillPoints.SkillPoints - s.Cost > 0)
                        {
                            MECH_SkillPoints.SkillPoints -= s.Cost;
                            MECH_SkillPoints.ShootingRank++;
                            s.isSkillUsed = true;
                        }
                        break;
                    case 101:
                        if (MECH_SkillPoints.SkillPoints - s.Cost > 0)
                        {
                            MECH_SkillPoints.SkillPoints -= s.Cost;
                            MECH_SkillPoints.ShootingRank++;
                            s.isSkillUsed = true;
                        }
                        break;
                    case 102:
                        if (MECH_SkillPoints.SkillPoints - s.Cost > 0)
                        {
                            MECH_SkillPoints.SkillPoints -= s.Cost;
                            MECH_SkillPoints.ShootingRank++;
                            s.isSkillUsed = true;
                        }
                        break;
                    case 300:
                        if (MECH_SkillPoints.SkillPoints - s.Cost > 0)
                        {
                            MECH_SkillPoints.SkillPoints -= s.Cost;
                            MECH_SkillPoints.trashCarryWeight++;
                            s.isSkillUsed = true;
                        }
                        break;
                    case 301:
                        if (MECH_SkillPoints.SkillPoints - s.Cost > 0)
                        {
                            MECH_SkillPoints.SkillPoints -= s.Cost;
                            MECH_SkillPoints.trashCarryWeight++;
                            s.isSkillUsed = true;
                        }
                        break;
                    case 302:
                        if (MECH_SkillPoints.SkillPoints - s.Cost > 0)
                        {
                            MECH_SkillPoints.SkillPoints -= s.Cost;
                            MECH_SkillPoints.trashCarryWeight++;
                            s.isSkillUsed = true;
                        }
                        break;
                    case 303:
                        if (MECH_SkillPoints.SkillPoints - s.Cost > 0)
                        {
                            MECH_SkillPoints.SkillPoints -= s.Cost;
                            MECH_SkillPoints.trashCarryWeight++;
                            s.isSkillUsed = true;
                        }
                        break;
                    case 400:
                        if (MECH_SkillPoints.SkillPoints - s.Cost > 0)
                        {
                            MECH_SkillPoints.SkillPoints -= s.Cost;
                            MECH_SkillPoints.BuildingRank++;
                            s.isSkillUsed = true;
                        }
                        break;
                    case 401:
                        if (MECH_SkillPoints.SkillPoints - s.Cost > 0)
                        {
                            MECH_SkillPoints.SkillPoints -= s.Cost;
                            MECH_SkillPoints.BuildingRank++;
                            s.isSkillUsed = true;
                        }
                        break;
                    case 402:
                        if (MECH_SkillPoints.SkillPoints - s.Cost > 0)
                        {
                            MECH_SkillPoints.SkillPoints -= s.Cost;
                            MECH_SkillPoints.BuildingRank++;
                            s.isSkillUsed = true;
                        }
                        break;
                    case 403:
                        if (MECH_SkillPoints.SkillPoints - s.Cost > 0)
                        {
                            MECH_SkillPoints.SkillPoints -= s.Cost;
                            MECH_SkillPoints.BuildingRank++;
                            s.isSkillUsed = true;
                        }
                        break;
                }
            }
        });
    }
	
	// Update is called once per frame
	void Update () {
        ID = GUI_PlayerProfileReadMoretab.ID;
        if (MECH_SkillPoints.Skills[ID].isSkillUsed)
        {
            gameObject.GetComponent<Button>().image.color = Color.black;
            gameObject.GetComponent<Button>().interactable = false;
            PurchaseText.text = "Purchased";
        }
        else
        {
            gameObject.GetComponent<Button>().image.color = Color.white;
            gameObject.GetComponent<Button>().interactable = true;
            PurchaseText.text = "Purchase";
        }
    }
}
