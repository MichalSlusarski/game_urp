using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMousePosition : MonoBehaviour
{
    void Update()
    {
        //if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; 

            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider != null)
                {
                    Debug.Log(hit.point);
                    transform.position = hit.point;
                }
            }
        }
    }
}
