using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.tag == "Plane")
        {
            Destroy(gameObject);
        }
    }
}
