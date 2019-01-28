using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MECH_SkillPoints : MonoBehaviour {
   
    public static int trashCarryWeight = 1;
    public static int SkillPoints = 1000;
    public static Dictionary<int, GUI_PlayerProfileSkillButtons> Skills;
    public static int ShootingRank;
    public static int BuildingRank;
    void Awake(){
        SkillPoints = 1000;
        trashCarryWeight = 1;
        Skills = new Dictionary<int, GUI_PlayerProfileSkillButtons>();
        ShootingRank = 0;
        BuildingRank = 0;
    }

    
}
