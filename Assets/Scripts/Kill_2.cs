using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_2 : MonoBehaviour
{
    int direction = 1; //int direction where 0 is stay, 1 up, -1 down    
    float left_2 = 8.60f;
    float right_2 = 11.30f;

    float speed = 3;

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
        if (this.transform.CompareTag("Enemy_4"))
        {
            if (transform.position.x >= right_2)
                direction = -1;

            if (transform.position.x <= left_2)
                direction = 1;

            transform.Translate(speed * direction * Time.deltaTime, 0, 0);
        }

        if (this.transform.CompareTag("Enemy_5"))
        {
            if (transform.position.x >= right_2)
                direction = -1;

            if (transform.position.x <= left_2)
                direction = 1;

            transform.Translate(speed * direction * Time.deltaTime, 0, 0);
        }

        if (this.transform.CompareTag("Enemy_6"))
        {
            if (transform.position.x >= right_2)
                direction = -1;

            if (transform.position.x <= left_2)
                direction = 1;

            transform.Translate(speed * direction * Time.deltaTime, 0, 0);
        }

        if (this.transform.CompareTag("Enemy_7"))
        {
            if (transform.position.x >= right_2)
                direction = -1;

            if (transform.position.x <= left_2)
                direction = 1;

            transform.Translate(speed * direction * Time.deltaTime, 0, 0);
        }

        if (this.transform.CompareTag("Enemy_8"))
        {
            if (transform.position.x >= right_2)
                direction = -1;

            if (transform.position.x <= left_2)
                direction = 1;

            transform.Translate(speed * direction * Time.deltaTime, 0, 0);
        }

    }


}
