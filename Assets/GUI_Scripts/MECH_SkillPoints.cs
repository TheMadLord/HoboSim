using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MECH_SkillPoints : MonoBehaviour {
    
    //public class Skill {
    //    
    //}

    public static int trashCarryWeight = 1;
    public static int SkillPoints = 1000;
    public static Dictionary<int, GUI_PlayerProfileSkillButtons> Skills;

    void Awake(){
        SkillPoints = 1000;
        trashCarryWeight = 1;
        Skills = new Dictionary<int, GUI_PlayerProfileSkillButtons>();
        //SkillTree[1] = new Skill();
    }

    
}
