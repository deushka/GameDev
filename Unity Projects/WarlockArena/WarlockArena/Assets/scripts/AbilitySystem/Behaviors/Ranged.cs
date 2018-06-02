using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranged : SkillBehavior {

    private const string name = "Ranged";
    private const string description = "Ranged Attack!";
    private const BehaviorStartTime startTime = BehaviorStartTime.Beginning;
    //private const Sprite icon;  RANGED ATTACK ICON

    private float distance;

    public Ranged(float mDist)
        : base(new BasicObjectInformation(name, description), startTime)
    {
        distance = mDist;
    }

    public override void PerformBehavior(GameObject playerObject, GameObject hitObject)
    {
        StartCoroutine(CheckDistance(playerObject.transform.position));
    }

    private IEnumerator CheckDistance(Vector2 startPosition)
    {
        float tempDistance = Vector2.Distance(startPosition, this.transform.position);
        while (tempDistance <= Distance)
        {
            tempDistance = Vector2.Distance(startPosition, this.transform.position);
        }
        //TODO DESTROY
        this.gameObject.SetActive(false);
        yield return null;
    }

    public float Distance
    {
        get { return distance; }
    }

}
