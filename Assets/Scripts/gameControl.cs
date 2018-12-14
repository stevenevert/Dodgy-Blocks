using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class gameControl : MonoBehaviour
    {
        [SerializeField] private Text uiText;
    [SerializeField] private Text TimeText;
    public GameObject heart1, heart2, heart3, gameOver;
        public static int health;
        public static int Lvl1Deaths = 999;
        public static int Lvl2Deaths = 999;
        public static int Lvl3Deaths = 999;
        public static int Lvl4Deaths = 999;
        public static int Lvl5Deaths = 999;
        public static int totalDeaths = 999;
    public static float Lvl1Time = 999.99f;
    public static float Lvl2Time = 999.99f;
    public static float Lvl3Time = 999.99f;
    public static float Lvl4Time = 999.99f;
    public static float Lvl5Time = 999.99f;


    void OnEnable()
    {
        Load();
    }

    void OnDisable()
    {
        Save();
    }

    // Use this for initialization
    void Start()
        {
        Scene currentScene = SceneManager.GetActiveScene();
        string currentName = currentScene.name;
        if(!File.Exists(Application.persistentDataPath + "/deaths.dat"))
        {
            Save();
        }
        switch (currentName)
        {
            case "Level_Eric":
                uiText.text = Lvl1Deaths.ToString();
                TimeText.text = Lvl1Time.ToString("F");
                break;
            case "Level_Steven":
                uiText.text = Lvl2Deaths.ToString();
                TimeText.text = Lvl2Time.ToString("F");
                break;
            case "Level_Dominick":
                uiText.text = Lvl3Deaths.ToString();
                TimeText.text = Lvl3Time.ToString("F");
                break;
            case "Level_Matthew":
                uiText.text = Lvl4Deaths.ToString();
                TimeText.text = Lvl4Time.ToString("F");
                break;
            case "Level_Kian":
                uiText.text = Lvl5Deaths.ToString();
                TimeText.text = Lvl5Time.ToString("F");
                break;
            default: break;
        }
        //uiText.text = Lvl1Deaths.ToString();
       // TimeText.text = Lvl1Time.ToString("F");
        health = 3;
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(true);
            gameOver.gameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

        if (health > 3)
                health = 3;

            switch (health)
            {
                case 3:
                    heart1.gameObject.SetActive(true);
                    heart2.gameObject.SetActive(true);
                    heart3.gameObject.SetActive(true);
                    break;
                case 2:
                    heart1.gameObject.SetActive(true);
                    heart2.gameObject.SetActive(true);
                    heart3.gameObject.SetActive(false);
                    break;
                case 1:
                    heart1.gameObject.SetActive(true);
                    heart2.gameObject.SetActive(false);
                    heart3.gameObject.SetActive(false);
                    break;
                case 0:
                    heart1.gameObject.SetActive(false);
                    heart1.gameObject.SetActive(false);
                    heart1.gameObject.SetActive(false);
                    gameOver.gameObject.SetActive(true);
                    Time.timeScale = 0;
                    break;
            }
            
    
        }

    public void Reset(int num)
    {
        Lvl1Deaths = num;
        Lvl2Deaths = num;
        Lvl3Deaths = num;
        Lvl4Deaths = num;
        Lvl5Deaths = num;
        totalDeaths = num;
        uiText.text = Lvl1Deaths.ToString();
    }
        
            public void Save()
            {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/deaths.dat");

        DeathData data = new DeathData();
        data.Lvl1Deaths = Lvl1Deaths;
        data.Lvl2Deaths = Lvl2Deaths;
        data.Lvl3Deaths = Lvl3Deaths;
        data.Lvl4Deaths = Lvl4Deaths;
        data.Lvl5Deaths = Lvl5Deaths;
        data.totalDeaths = totalDeaths;
        data.Lvl1Time = Lvl1Time;
        data.Lvl2Time = Lvl2Time;
        data.Lvl3Time = Lvl3Time;
        data.Lvl4Time = Lvl4Time;
        data.Lvl5Time = Lvl5Time;

        bf.Serialize(file, data);
        file.Close();
            }

            public void Load()
            {
                if(File.Exists(Application.persistentDataPath + "/deaths.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/deaths.dat", FileMode.Open);
            DeathData data = (DeathData)bf.Deserialize(file);

            Lvl1Deaths = data.Lvl1Deaths;
            Lvl2Deaths = data.Lvl2Deaths;
            Lvl3Deaths = data.Lvl3Deaths;
            Lvl4Deaths = data.Lvl4Deaths;
            Lvl5Deaths = data.Lvl5Deaths;
            totalDeaths = data.totalDeaths;
            Lvl1Time = data.Lvl1Time;
            Lvl2Time = data.Lvl2Time;
            Lvl3Time = data.Lvl3Time;
            Lvl4Time = data.Lvl4Time;
            Lvl5Time = data.Lvl5Time;

        }
            }

    }

[Serializable]
class DeathData
{
    public int Lvl1Deaths;
    public int Lvl2Deaths;
    public int Lvl3Deaths;
    public int Lvl4Deaths;
    public int Lvl5Deaths;
    public int totalDeaths;
    public float Lvl1Time;
    public float Lvl2Time;
    public float Lvl3Time;
    public float Lvl4Time;
    public float Lvl5Time;
}
