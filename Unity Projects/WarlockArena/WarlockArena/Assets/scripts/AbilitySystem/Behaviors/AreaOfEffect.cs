using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

[RequireComponent(typeof(CircleCollider2D))]
public class AreaOfEffect : SkillBehavior {

    private const string abName = "Area of Effect";
    private const string abDescription = "Area of Damage!";
    private const BehaviorStartTime startTime = BehaviorStartTime.End;
    //private const Sprite icon;  
    private float areaRadius;   //radius of sphere collider
    private float effectDuration; // how long the effect lasts
    private Stopwatch durationTimer = new Stopwatch();
    private float baseEffectDamage;
    private bool isOccupied;
    private float damageTickDurationion;
    private float distance;

    public AreaOfEffect(float ar, float ed, float dmg)
        : base(new BasicObjectInformation(abName, abDescription), startTime)
    {
        areaRadius = ar;
        effectDuration = ed;
        baseEffectDamage = dmg;
        isOccupied = false;
        damageTickDurationion = 1f;
    }

    public override void PerformBehavior(GameObject playerObject, GameObject hitObject)
    {
        CircleCollider2D cc = this.gameObject.GetComponent<CircleCollider2D>();
        
        cc.radius = areaRadius;
        cc.isTrigger = true;

        StartCoroutine(AOE());
    }
    private IEnumerator AOE()
    {
        durationTimer.Start(); // turns on timer

        while(durationTimer.Elapsed.TotalSeconds < effectDuration)
        {
            if (isOccupied)
            {
                // do damage here
            }
            yield return new WaitForSeconds(damageTickDurationion);
        }
        durationTimer.Stop();
        durationTimer.Reset();
        yield return null;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isOccupied)
        {
            //do damage
        }
        else
            isOccupied = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isOccupied = false;
    }

}
