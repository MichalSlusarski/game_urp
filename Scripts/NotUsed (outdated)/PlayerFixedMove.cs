using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFixedMove : MonoBehaviour
{
    [SerializeField] Vector3 endPosition;

    void Start()
    {
        gameObject.transform.position = endPosition;
    }
    
    void Update()
    {
        if(Input.GetKeyDown("w"))
        {
            endPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1.25f);
        }
        if(Input.GetKeyDown("s"))
        {
            endPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1.25f);
        }
        if(Input.GetKeyDown("a"))
        {
            endPosition = new Vector3(transform.position.x - 1.25f, transform.position.y, transform.position.z);
        }
        if(Input.GetKeyDown("d"))
        {
            endPosition = new Vector3(transform.position.x + 1.25f, transform.position.y, transform.position.z);
        }

        gameObject.transform.position = endPosition;
    }
}
