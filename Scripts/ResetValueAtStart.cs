using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetValueAtStart : MonoBehaviour
{
    [SerializeField]
    SO_Integer SO_Integer;

    void Start()
    {
        while (SO_Integer.Integer < 100)
        {
            SO_Integer.Integer++;
            if(SO_Integer.Integer >= 100)
            {
                break;
            }
        }
    }
}
