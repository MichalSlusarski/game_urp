using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnGrid : MonoBehaviour
{ 
    [SerializeField] GameObject gameobjectPrefab;
    [SerializeField] Vector3[] spawnPosition;
     
    void Awake()
    {
        SpawnPrefab();
    }

    void SpawnPrefab(int prefabIndex = 0)
    {
        GameObject _GameObject;
        _GameObject = Instantiate(gameobjectPrefab, spawnPosition[RandomPositionIndex()], Quaternion.identity) as GameObject;
        _GameObject.transform.SetParent(transform);
    }

    int RandomPositionIndex()
    {
        int randomPosition = Random.Range(0, 6);
        return randomPosition;
    }
}
