using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntToText : MonoBehaviour
{
    [SerializeField]
    SO_Integer ScriptableObject;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = ScriptableObject.Integer.ToString();
    }
}
