using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private Vector2 targetPos;
    public float movement;

    public float speed;
    public int maxHight;
    public int minHight;

    public int health;

    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        const int stepSize = 2;
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHight - stepSize + 1){
            targetPos = new Vector2(transform.position.x, transform.position.y + movement);
            
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHight + stepSize - 1)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - movement);

        }
    }
}
