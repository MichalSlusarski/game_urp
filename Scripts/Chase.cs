using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    [SerializeField] NavMeshAgent thisObject;
    [SerializeField] Transform target;
    
    public void ChaseTheTarget()
    {
        //thisObject.transform.position = Vector3.MoveTowards(thisObject.transform.position, target.transform.position - offset, speed * Time.deltaTime);
        //thisObject.transform.LookAt(target.transform.position);

        thisObject.SetDestination(target.position);
        transform.LookAt(target);
    }
    
}
