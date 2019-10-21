using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacle;

    private float timeBetweenSpawn;
    public float startTimeBetweenSpawn;
    public float decreseTime;
    public float minTime;

    private void Update()
    {
        if (timeBetweenSpawn <= 0)
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            timeBetweenSpawn = startTimeBetweenSpawn;
            if (startTimeBetweenSpawn > minTime) {
                startTimeBetweenSpawn -= decreseTime;
            }
            
        }
        else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
    }

}
