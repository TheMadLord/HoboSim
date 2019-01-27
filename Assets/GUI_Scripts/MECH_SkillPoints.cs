using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MECH_SkillPoints : MonoBehaviour {
    
    public class Skill {
        
    }

    public static int trashCarryWeight = 1;
    public static int SkillPoints = 1000;
    public Dictionary<int, Skill> SkillTree;
    

    void Awake(){
        SkillPoints = 1000;
        trashCarryWeight = 1;
        SkillTree = new Dictionary<int, Skill>();
        SkillTree[1] = new Skill();
    }

    
}
