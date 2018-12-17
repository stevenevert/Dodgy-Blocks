using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    private Transform playerPos;
    private Player player;
    public float speed;
 
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }

}
