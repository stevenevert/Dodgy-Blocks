using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int coins = 0;
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    /// <summary>
    /// 
    /// </summary>
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    /// <summary>
    /// Updating the movement of the player
    /// </summary>
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }


    /// <summary>
    /// Adding a method which will check for collision with coin to destroy it and add to the counter
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "coin")
        {
            Destroy(other.gameObject);
            coins++;
        }
    }

}