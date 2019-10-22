using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{

    public GameObject obstacal;

    void Start()
    {
        Instantiate(obstacal, transform.position, Quaternion.identity);
    }

}
