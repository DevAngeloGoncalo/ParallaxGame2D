using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public float spawnRate = 2f;

    float nextSpawn = 0.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        int randomEnemy;

        if (Time.time > nextSpawn)
        {
            randomEnemy = Random.Range(0, enemies.Length);

            nextSpawn = Time.time + spawnRate;
            float fRandomRange = Random.Range(12.4F, 28f);
            Vector2 spawnPoint = new Vector2(fRandomRange, transform.position.y);
            Instantiate(enemies[randomEnemy], spawnPoint, Quaternion.identity);
        }
    }
}