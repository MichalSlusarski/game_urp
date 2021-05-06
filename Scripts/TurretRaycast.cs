using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRaycast : MonoBehaviour
{
    [SerializeField] private SO_Integer SO_Integer;
    [SerializeField] float range = 100f;
    [SerializeField] GameObject turret; 

    void Update()
    {
        Debug.DrawRay(transform.position, Vector3.right * range, Color.red);
        
        if(this.enabled)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        
        if(Physics.Raycast(turret.transform.position, turret.transform.right, out hit, range))
        {
            Debug.Log(hit.transform.name);

            if(hit.transform.tag == "Player")
            {
            SO_Integer.Integer--;
            }
        }
    }
}
