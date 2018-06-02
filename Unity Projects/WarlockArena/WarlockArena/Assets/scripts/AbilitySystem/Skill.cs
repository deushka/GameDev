using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class Skill {
    private BasicObjectInformation objectInfo;
    private float Cooldown; // secs
    private int UpgradeCost;
    private List <SkillBehavior> behaviors; 
    private bool requiresTarget; // нужна ли цель
    private bool canCastOnSelf; // Кастуем на себя
    private GameObject particleEffect; // needs assigned when we create the ability
    private float castTime;
    private SkillType type;

    public enum SkillType
    {
        Spell,
        Melee,
        Buff
    }


    public Skill(BasicObjectInformation aInfo, int cost)
    {
        behaviors = new List<SkillBehavior>();
        objectInfo = aInfo;
        UpgradeCost = cost;
        Cooldown = 0f;
        requiresTarget = false;
        canCastOnSelf = false;
    }

    public Skill(BasicObjectInformation aInfo, float cd, int cost, List<SkillBehavior> abehav, bool reqTarg, bool canCast, GameObject partEff)
    {
        objectInfo = aInfo;
        canCastOnSelf = canCast;
        particleEffect = partEff;
        behaviors = new List<SkillBehavior>();
        behaviors = abehav;
        requiresTarget = reqTarg;
        Cooldown = cd;
        UpgradeCost = cost;
    }
    public BasicObjectInformation SkillInfo
    {
        get { return objectInfo; }
    }
    public float SkillCD
    {
        get { return Cooldown; }
    }
    public int SkillCost
    {
        get { return UpgradeCost; }
    }
    public bool SkillRequiresTarget
    {
        get { return requiresTarget; }
    }
    public bool SkillCanCastOnSelf
    {
        get { return canCastOnSelf; }
    }
    public List<SkillBehavior> SkillBehavior
    {
        get { return behaviors; }
    }

    public virtual void SkillUse()
    {

    }

}
