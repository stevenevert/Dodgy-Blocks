using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {


    

    int direction = 1; //int direction where 0 is stay, 1 up, -1 down    
    float left_1= -10.40f;
    float right_1 = -5.80f;

    float speed = 5;

    [SerializeField] Transform spawnPoint;


    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.CompareTag("Player"))
        {
            other.transform.position = spawnPoint.position;
            gameControl.health -= 1;
        }
    }

  

    // Moving enemies
    void Update()
    {
        // First set of enemies
        if (this.transform.CompareTag("Enemy_1"))

        {
            if (transform.position.x >= right_1)
                direction = -1;

            if (transform.position.x <= left_1)
                direction = 1;

            transform.Translate(speed * direction * Time.deltaTime, 0, 0);
        }

        if (this.transform.CompareTag("Enemy_2"))
        {
            if (transform.position.x >= right_1)
                direction = -1;

            if (transform.position.x <= left_1)
                direction = 1;

            transform.Translate(speed * direction * Time.deltaTime, 0, 0);
        }

        if (this.transform.CompareTag("Enemy_3"))
        {
            if (transform.position.x >= right_1)
                direction = -1;

            if (transform.position.x <= left_1)
                direction = 1;

            transform.Translate(speed * direction * Time.deltaTime, 0, 0);
        }

    }


}
