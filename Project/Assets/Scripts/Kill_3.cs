using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_3 : MonoBehaviour
{
    int direction = 1; //int direction where 0 is stay, 1 up, -1 down    
    float left_3 = -2.97f;
    float right_3 = 5.74f;

    float speed = 10;

    [SerializeField] Transform spawnPoint;


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Player"))
        {
            other.transform.position = spawnPoint.position;
            gameControl.health -= 1;
        }
    }


    // Moving enemies
    void Update()
    {
        // Second set of enemies
        if (this.transform.CompareTag("Enemy_9"))
        {
            if (transform.position.x >= right_3)
                direction = -1;

            if (transform.position.x <= left_3)
                direction = 1;

            transform.Translate(speed * direction * Time.deltaTime, 0, 0);
        }

        if (this.transform.CompareTag("Enemy_10"))
        {
            if (transform.position.x >= right_3)
                direction = -1;

            if (transform.position.x <= left_3)
                direction = 1;

            transform.Translate(speed * direction * Time.deltaTime, 0, 0);
        }

        if (this.transform.CompareTag("Enemy_11"))
        {
            if (transform.position.x >= right_3)
                direction = -1;

            if (transform.position.x <= left_3)
                direction = 1;

            transform.Translate(speed * direction * Time.deltaTime, 0, 0);
        }

    }


}
