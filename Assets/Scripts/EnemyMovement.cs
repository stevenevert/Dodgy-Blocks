using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    
    public float left;
    public float right;
    public float up;
    public float down;
    public float speed;
    private Vector3 originalPosition;
    private bool xComeback;
    private bool yComeback;
    private bool yController;
    private bool xController;
    private int xDirection;
    private int yDirection = 0;
    [SerializeField] Transform spawnPoint;
    private UIControl deathMan;

    void Awake()
    {
        deathMan = GameObject.FindObjectOfType<UIControl>();
    }
    
    void Start () {
        originalPosition = this.transform.position;
        if (up == 0 && down == 0)
            yController = false;
        else
            yController = true;
        if (right == 0 && left == 0)
            xController = false;
        else
            xController = true;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.position = spawnPoint.position;
            deathMan.upDeaths();

        }
 
    }
    void Update() {
        if (xController)
        {
            if (!xComeback)
            {
                if (transform.position.x >= originalPosition.x - left)
                {
                    xDirection = -1;
                }
                else xComeback = true;
            }
            else
            {
                if (transform.position.x <= originalPosition.x + right)
                {
                    xDirection = 1;
                }
                else xComeback = false;
            }
        }
        if (yController)
        {
            if (!yComeback)
            {
                if (transform.position.y >= originalPosition.y - down)
                {
                    yDirection = -1;
                }
                else yComeback = true;
            }
            else
            {
                if (transform.position.y <= originalPosition.y + up)
                {
                    yDirection = 1;
                }
                else yComeback = false;
            }
        }
        transform.Translate(speed * xDirection * Time.deltaTime, speed * yDirection * Time.deltaTime, 0);
    }
}
