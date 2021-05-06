using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTurret : MonoBehaviour
{
    [SerializeField] GameObject gameObject;
    [SerializeField] int xPos;
    [SerializeField] int zPos;
    [SerializeField] int yPos;
    [SerializeField] int numberOfObjects;
    [SerializeField] int maxNumber = 3;

    void Start()
    {
        StartCoroutine(turretSpawn());
    }

    IEnumerator turretSpawn()
    {
        while (numberOfObjects < maxNumber)
        {
            xPos = Random.Range(-4, 4);
            zPos = Random.Range(-4, 4);
            GameObject clone = Instantiate(gameObject, new Vector3(xPos, yPos, zPos), Quaternion.identity) as GameObject;
            yield return new WaitForSeconds(0.1f);
            numberOfObjects += 1;
        }
    }
}
