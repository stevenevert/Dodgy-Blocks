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
        public GameObject heart1, heart2, heart3, gameOver;
        public static int health;
        public static int Lvl1Deaths;
        public int Lvl2Deaths;
        public int Lvl3Deaths;
        public int Lvl4Deaths;
        public int Lvl5Deaths;
        public int totalDeaths;

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
       uiText.text = Lvl1Deaths.ToString();
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
}
