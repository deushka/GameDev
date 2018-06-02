using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillBehavior: MonoBehaviour{
    private BasicObjectInformation objectInfo;
    private BehaviorStartTime startTime;

    public SkillBehavior(BasicObjectInformation aInfo, BehaviorStartTime sTime)
    {
        objectInfo = aInfo;
        startTime = sTime;
    }

    public enum BehaviorStartTime
    {
        Beginning,
        Middle,
        End
    }
    public virtual void PerformBehavior(GameObject playerObject, GameObject hitObject)
    {
        Debug.LogWarning("NEED SOME BEHAVIOR!!!");
    }
    public BasicObjectInformation SkillBehaviorInfo
    {
        get { return objectInfo; }
    }
    public BehaviorStartTime SkillBehaviorStartTime
    {
        get { return startTime; }
    }
}
