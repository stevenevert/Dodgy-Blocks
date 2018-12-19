using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    private Transform playerPos;
    private Player player;
    public float speed;
 /// <summary>
 /// This code programs the enemy to move towards the player's position
 /// At the start of the game, the player's gameobject is taken and put into a private variable.
 /// It takes the player's position and puts that into a Transform variable
 /// </summary>
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }
    /// <summary>
    /// Every game tick this move sthe enemy towards the player using the variables found at the start
    /// </summary>

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }

}
