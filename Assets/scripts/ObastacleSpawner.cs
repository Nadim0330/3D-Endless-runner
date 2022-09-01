using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObastacleSpawner : MonoBehaviour
{

    public GameObject testObject;
    public float xRange = 1.0f;
    public float zRange = 1.0f;
    public float minSpawnTime = 1.0f;
    public float maxSpawnTime = 10.0f;

    public void Start()
    {
        Invoke("SpawnItem", Random.Range(minSpawnTime, maxSpawnTime));
    }


    void SpawnItem()
    {
        float xOffset = Random.Range(-4.86f, 4.60f);
        float zOffset = Random.Range(-zRange, zRange);
        int spawnObjectIndex = Random.Range(0, 1);
        GameObject goInst = (GameObject)Instantiate(testObject, transform.position + new Vector3(xOffset,0.0f ,0.0f), testObject.transform.rotation);
        goInst.transform.parent = transform;
        Invoke("SpawnItem", Random.Range(minSpawnTime, maxSpawnTime));
    }
}

