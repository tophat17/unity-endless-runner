using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Player : MonoBehaviour
{

    private Vector2 targetPos;
    public float movment;

    public float speed;
    public float maxHight;
    public float minHight;

    public int health;
    public int startTimer;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHight){
            targetPos = new Vector2(transform.position.x, transform.position.y + movment);
            
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - movment);

        }
    }
}
