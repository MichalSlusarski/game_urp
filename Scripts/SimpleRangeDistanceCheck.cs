using UnityEngine;

public class SimpleRangeDistanceCheck : MonoBehaviour
{
    [SerializeField] GameObject thisObject;
    [SerializeField] GameObject Target;
    [SerializeField] float range = 20f;

    [Header("Debug:")]  
    public bool isTargetInRange = false;

    public bool CheckIfInRange()
    {
        float distance = Vector3.Distance(Target.transform.position, thisObject.transform.position);

        if(distance > range)
        {
            isTargetInRange = false;
            return false;
        }
        else
        {
            isTargetInRange = true;
            Debug.Log("Target in range");
            return true;
        }
        return false;
    }
}

