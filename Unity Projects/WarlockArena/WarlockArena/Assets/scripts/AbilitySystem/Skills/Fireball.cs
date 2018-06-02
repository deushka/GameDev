using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : Skill {
    private const string abName = "Fireball";
    private const string abDescription = "KABOOOM!";
    //private const Sprite icon;  

    private float baseEffectDamage = 10f,
                  baseEffectDuration= 1f,
                  baseEffectRadius= 0.3f;


    public Fireball() :base(new BasicObjectInformation(abName, abDescription), 0)
    {
        this.SkillBehavior.Add(new Ranged(5f));
        this.SkillBehavior.Add(new AreaOfEffect(baseEffectRadius, baseEffectDuration, baseEffectDamage));
    }
}
