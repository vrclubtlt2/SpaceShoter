using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public Transform leftBorder;
    public Transform rightBorder;

    public float spawnTimer;
    public float spawnInterval = 2;

    

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            Spawn();
            spawnTimer = spawnInterval;
        }
    }

    public void Spawn()
    {
        float randx = Random.Range(leftBorder.position.x, rightBorder.position.x);

        Vector2 newPos = transform.position;
        newPos.x = randx;
        Instantiate(prefab, newPos, Quaternion.identity);
    }
}
