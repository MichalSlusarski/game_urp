using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFixedMove : MonoBehaviour
{
    [SerializeField] Vector3 endPosition;

    void Start()
    {
        gameObject.transform.position = endPosition;
    }
    
    void Update()
    {
        if(Input.GetKeyDown("u"))
        {
            endPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1.25f);
        }
        if(Input.GetKeyDown("j"))
        {
            endPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1.25f);
        }
        if(Input.GetKeyDown("h"))
        {
            endPosition = new Vector3(transform.position.x - 1.25f, transform.position.y, transform.position.z);
        }
        if(Input.GetKeyDown("k"))
        {
            endPosition = new Vector3(transform.position.x + 1.25f, transform.position.y, transform.position.z);
        }

        gameObject.transform.position = endPosition;
    }
}
