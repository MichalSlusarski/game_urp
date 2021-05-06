using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] SimpleRangeDistanceCheck simpleRangeDistanceCheck;
    [SerializeField] Chase chase;
    //[SerializeField] Explode explode;

    void Update()
    {
        if (simpleRangeDistanceCheck.isTargetInRange == false)
        {
            simpleRangeDistanceCheck.CheckIfInRange();
        }
        if (simpleRangeDistanceCheck.isTargetInRange == true)
        {
            chase.ChaseTheTarget();
        }
        //if (chase.) 
    }

}
