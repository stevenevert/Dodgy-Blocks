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
     /*public static int Lvl1Deaths = 999;
     public static int Lvl2Deaths = 999;
     public static int Lvl3Deaths = 999;
     public static int Lvl4Deaths = 999;
     public static int Lvl5Deaths = 999;
     public static int totalDeaths = 999;*/
    public static int[] deaths = new int[10] {9999,9999,9999,9999,9999,9999,9999,9999,9999,9999};
    /*public static float Lvl1Time = 999.99f;
    public static float Lvl2Time = 999.99f;
    public static float Lvl3Time = 999.99f;
    public static float Lvl4Time = 999.99f;
    public static float Lvl5Time = 999.99f;*/
    public static float[] bestTime = new float[10] { 999.99f, 999.99f, 999.99f, 999.99f, 999.99f, 999.99f, 999.99f, 999.99f, 999.99f,999.99f };


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
            case "Level_Steven":
                uiText.text = deaths[1].ToString();
                TimeText.text = bestTime[1].ToString("F");
                break;
            case "Level_Dominick":
                uiText.text = deaths[2].ToString();
                TimeText.text = bestTime[2].ToString("F");
                break;
            case "Level_Eric1":
                uiText.text = deaths[3].ToString();
                TimeText.text = bestTime[3].ToString("F");
                break;
            case "Level_Kian1":
                uiText.text = deaths[4].ToString();
                TimeText.text = bestTime[4].ToString("F");
                break;
            case "Level_Matthew":
                uiText.text = deaths[5].ToString();
                TimeText.text = bestTime[5].ToString("F");
                break;
            case "Level_Kian2":
                uiText.text = deaths[6].ToString();
                TimeText.text = bestTime[6].ToString("F");
                break;
            case "Level_Kian3":
                uiText.text = deaths[7].ToString();
                TimeText.text = bestTime[7].ToString("F");
                break;
            case "Level_Kian4":
                uiText.text = deaths[8].ToString();
                TimeText.text = bestTime[8].ToString("F");
                break;
            case "Level_Eric2":
                uiText.text = deaths[9].ToString();
                TimeText.text = bestTime[9].ToString("F");
                break;

            default: break;
        }
               }

        // Update is called once per frame
        void Update()
        {

       
        }

    public void Reset()
    {
      deaths = new int[10] { 9999, 9999, 9999, 9999, 9999, 9999, 9999, 9999, 9999,9999 };
      bestTime = new float[10] { 999.99f, 999.99f, 999.99f, 999.99f, 999.99f, 999.99f, 999.99f, 999.99f, 999.99f,999.99f };
}
        
            public void Save()
            {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/deaths.dat");

        DeathData data = new DeathData();
        /*data.Lvl1Deaths = Lvl1Deaths;
        data.Lvl2Deaths = Lvl2Deaths;
        data.Lvl3Deaths = Lvl3Deaths;
        data.Lvl4Deaths = Lvl4Deaths;
        data.Lvl5Deaths = Lvl5Deaths;
        data.totalDeaths = totalDeaths;
        data.Lvl1Time = Lvl1Time;
        data.Lvl2Time = Lvl2Time;
        data.Lvl3Time = Lvl3Time;
        data.Lvl4Time = Lvl4Time;
        data.Lvl5Time = Lvl5Time;*/
        data.deaths = deaths;
        data.bestTime = bestTime;

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
            deaths = data.deaths;
            bestTime = data.bestTime;
            /*Lvl1Deaths = data.Lvl1Deaths;
            Lvl2Deaths = data.Lvl2Deaths;
            Lvl3Deaths = data.Lvl3Deaths;
            Lvl4Deaths = data.Lvl4Deaths;
            Lvl5Deaths = data.Lvl5Deaths;
            totalDeaths = data.totalDeaths;
            Lvl1Time = data.Lvl1Time;
            Lvl2Time = data.Lvl2Time;
            Lvl3Time = data.Lvl3Time;
            Lvl4Time = data.Lvl4Time;
            Lvl5Time = data.Lvl5Time;*/

        }
            }

    }

[Serializable]
class DeathData
{
    public int[] deaths = new int[10];
    public float[] bestTime = new float[10];

    /*public int Lvl1Deaths;
    public int Lvl2Deaths;
    public int Lvl3Deaths;
    public int Lvl4Deaths;
    public int Lvl5Deaths;
    public int totalDeaths;
    public float Lvl1Time;
    public float Lvl2Time;
    public float Lvl3Time;
    public float Lvl4Time;
    public float Lvl5Time;*/

}
