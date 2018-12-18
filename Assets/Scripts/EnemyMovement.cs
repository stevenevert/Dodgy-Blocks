using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour {

    // Creating vars that will hold values through the access Unity library methods
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

    /// <summary>
    /// Initializing UI element for game deaths
    /// </summary>
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

    /// <summary>
    /// Defining method that will count deaths, respawn and reset the scene accordingly
    /// </summary>
    /// <param name="collision"></param>
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Obtaining scene info
        Scene currentScene = SceneManager.GetActiveScene();
        string currentName = currentScene.name;

        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.position = spawnPoint.position;
            deathMan.upDeaths();
          
            // Commented out considering that we considered we shouldn't restart scenes throughout gameplay since it resets everything
            /*
            // Resetting the scene in certain levels depending if the "goal" area is the same as the original spawn point
            switch (currentName)
            {
                case "Level_Eric2":
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    break;
                default: break;
            }
            */
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
