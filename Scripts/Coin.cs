using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    SO_Integer SO_Integer;

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            SO_Integer.Integer += 1;
            Destroy(gameObject);
        }
    }
}
