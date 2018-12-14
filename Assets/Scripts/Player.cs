using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    [SerializeField] Transform spawnPoint;
    private UIControl deathMan;
    /// <summary>
    /// 
    /// </summary>
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    void Awake()
    {
        deathMan = GameObject.FindObjectOfType<UIControl>();
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Enemy_1"))
        {
            transform.position = spawnPoint.position;
            deathMan.upDeaths();
        }

    }
}