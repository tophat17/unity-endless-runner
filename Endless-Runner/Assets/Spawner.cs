using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;

    private float timeBetweenSpawn;
    public float startTimeBetweenSpawn;
    public float decreseTime;
    public float minTime;

    private void Update()
    {
        if (timeBetweenSpawn <= 0)
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBetweenSpawn = startTimeBetweenSpawn;
            if (startTimeBetweenSpawn > minTime)
            {
                startTimeBetweenSpawn -= decreseTime;
            }

        }
        else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
    }

}