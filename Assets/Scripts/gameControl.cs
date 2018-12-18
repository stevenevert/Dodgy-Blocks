using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class gameControl : MonoBehaviour
    { //initialize all variables needed throughout game.
        [SerializeField] private Text uiText;
    [SerializeField] private Text TimeText;
    [SerializeField] private Text lvl1death;
    [SerializeField] private Text lvl1time;
    [SerializeField] private Text lvl2death;
    [SerializeField] private Text lvl2time;
    [SerializeField] private Text lvl3death;
    [SerializeField] private Text lvl3time;
    [SerializeField] private Text lvl4death;
    [SerializeField] private Text lvl4time;
    [SerializeField] private Text lvl5death;
    [SerializeField] private Text lvl5time;
    [SerializeField] private Text lvl6death;
    [SerializeField] private Text lvl6time;
    [SerializeField] private Text lvl7death;
    [SerializeField] private Text lvl7time;
    [SerializeField] private Text lvl8death;
    [SerializeField] private Text lvl8time;
    [SerializeField] private Text lvl9death;
    [SerializeField] private Text lvl9time;
    [SerializeField] private Text lvl10death;
    [SerializeField] private Text lvl10time;
    [SerializeField] private Text totalDeath;
    [SerializeField] private Text totalTime;

    public GameObject heart1, heart2, heart3, gameOver;
    public static int health;
     /*public static int Lvl1Deaths = 999;
     public static int Lvl2Deaths = 999;
     public static int Lvl3Deaths = 999;
     public static int Lvl4Deaths = 999;
     public static int Lvl5Deaths = 999;
     public static int totalDeaths = 999;*/
    public static int[] deaths = new int[11] {9999,9999,9999,9999,9999,9999,9999,9999,9999,9999,9999};
    /*public static float Lvl1Time = 999.99f;
    public static float Lvl2Time = 999.99f;
    public static float Lvl3Time = 999.99f;
    public static float Lvl4Time = 999.99f;
    public static float Lvl5Time = 999.99f;*/
    public static float[] bestTime = new float[11] { 999.99f, 999.99f, 999.99f, 999.99f, 999.99f, 999.99f, 999.99f, 999.99f, 999.99f,999.99f,999.99f };

    int j;
    int t;
    /// <summary>
    /// when the game begins a scene, load the data from a file
    /// </summary>
    void OnEnable()
    {
        Load();
    }
    /// <summary>
    /// when the game exits a scene, save the data to the file
    /// </summary>
    void OnDisable()
    {
        Save();
    }

    // Use this for initialization
    /// <summary>
    /// when the scene starts
    /// </summary>
    void Start()
        {
        Scene currentScene = SceneManager.GetActiveScene();
        string currentName = currentScene.name;
        //If the save file does not exist, create it.
        if(!File.Exists(Application.persistentDataPath + "/deaths.dat"))
        {
            Save();
        }
        //Switch statement to check which level is active
        switch (currentName)
        {//Display the correct score depending on which level is active.
            case "Level_Steven1":
                if (deaths[1] == 9999) uiText.text = "N/A";
                else uiText.text = deaths[1].ToString();
                if (bestTime[1] == 999.99f) TimeText.text = "N/A";
                else TimeText.text = bestTime[1].ToString("F");
                break;
            case "Level_Dominick":
                if (deaths[2] == 9999) uiText.text = "N/A";
                else uiText.text = deaths[2].ToString();
                if (bestTime[2] == 999.99f) TimeText.text = "N/A";
                else TimeText.text = bestTime[2].ToString("F");
                break;
            case "Level_Eric1":
                if (deaths[3] == 9999) uiText.text = "N/A";
                else uiText.text = deaths[3].ToString();
                if (bestTime[3] == 999.99f) TimeText.text = "N/A";
                else TimeText.text = bestTime[3].ToString("F");
                break;
            case "Level_Kian1":
                if (deaths[4] == 9999) uiText.text = "N/A";
                else uiText.text = deaths[4].ToString();
                if (bestTime[4] == 999.99f) TimeText.text = "N/A";
                else TimeText.text = bestTime[4].ToString("F");
                break;
            case "Level_Matthew":
                if (deaths[5] == 9999) uiText.text = "N/A";
                else uiText.text = deaths[5].ToString();
                if (bestTime[5] == 999.99f) TimeText.text = "N/A";
                else TimeText.text = bestTime[5].ToString("F");
                break;
            case "Level_Kian2":
                if (deaths[6] == 9999) uiText.text = "N/A";
                else uiText.text = deaths[6].ToString();
                if (bestTime[6] == 999.99f) TimeText.text = "N/A";
                else TimeText.text = bestTime[6].ToString("F");
                break;
            case "Level_Kian3":
                if (deaths[8] == 9999) uiText.text = "N/A";
                else uiText.text = deaths[8].ToString();
                if (bestTime[8] == 999.99f) TimeText.text = "N/A";
                else TimeText.text = bestTime[8].ToString("F");
                break;
            case "Level_Kian4":
                if (deaths[9] == 9999) uiText.text = "N/A";
                else uiText.text = deaths[9].ToString();
                if (bestTime[9] == 999.99f) TimeText.text = "N/A";
                else TimeText.text = bestTime[9].ToString("F");
                break;
            case "Level_Eric2":
                if (deaths[10] == 9999) uiText.text = "N/A";
                else uiText.text = deaths[10].ToString();
                if (bestTime[10] == 999.99f) TimeText.text = "N/A";
                else TimeText.text = bestTime[10].ToString("F");
                break;
            case "Level_Steven2":
                if (deaths[7] == 9999) uiText.text = "N/A";
                else uiText.text = deaths[7].ToString();
                if (bestTime[7] == 999.99f) TimeText.text = "N/A";
                else TimeText.text = bestTime[7].ToString("F");
                break;
            case "Menu": //Lots of text boxes on main menu means lots of if else statements
                if (deaths[1] == 9999) lvl1death.text = "N/A";
                else lvl1death.text = deaths[1].ToString();
                if (bestTime[1] == 999.99f) lvl1time.text = "N/A";
                else lvl1time.text = bestTime[1].ToString("F");
                if (deaths[2] == 9999) lvl2death.text = "N/A";
                else lvl2death.text = deaths[2].ToString();
                if (bestTime[2] == 999.99f) lvl2time.text = "N/A";
                else lvl2time.text = bestTime[2].ToString("F");
                if (deaths[3] == 9999) lvl3death.text = "N/A";
                else lvl3death.text = deaths[3].ToString();
                if (bestTime[3] == 999.99f) lvl3time.text = "N/A";
                else lvl3time.text = bestTime[3].ToString("F");
                if (deaths[4] == 9999) lvl4death.text = "N/A";
                else lvl4death.text = deaths[4].ToString();
                if (bestTime[4] == 999.99f) lvl4time.text = "N/A";
                else lvl4time.text = bestTime[4].ToString("F");
                if (deaths[5] == 9999) lvl5death.text = "N/A";
                else lvl5death.text = deaths[5].ToString();
                if (bestTime[5] == 999.99f) lvl5time.text = "N/A";
                else lvl5time.text = bestTime[5].ToString("F");
                if (deaths[6] == 9999) lvl6death.text = "N/A";
                else lvl6death.text = deaths[6].ToString();
                if (bestTime[6] == 999.99f) lvl6time.text = "N/A";
                else lvl6time.text = bestTime[6].ToString("F");
                if (deaths[7] == 9999) lvl7death.text = "N/A";
                else lvl7death.text = deaths[7].ToString();
                if (bestTime[7] == 999.99f) lvl7time.text = "N/A";
                else lvl7time.text = bestTime[7].ToString("F");
                if (deaths[8] == 9999) lvl8death.text = "N/A";
                else lvl8death.text = deaths[8].ToString();
                if (bestTime[8] == 999.99f) lvl8time.text = "N/A";
                else lvl8time.text = bestTime[8].ToString("F");
                if (deaths[9] == 9999) lvl9death.text = "N/A";
                else lvl9death.text = deaths[9].ToString();
                if (bestTime[9] == 999.99f) lvl9time.text = "N/A";
                else lvl9time.text = bestTime[9].ToString("F");
                if (deaths[10] == 9999) lvl10death.text = "N/A";
                else lvl10death.text = deaths[10].ToString();
                if (bestTime[10] == 999.99f) lvl10time.text = "N/A";
                else lvl10time.text = bestTime[10].ToString("F");
                if (deaths[0] == 9999) totalDeath.text = "N/A";
                else totalDeath.text = deaths[0].ToString();
                if (bestTime[0] == 999.99f) totalTime.text = "N/A";
                else totalTime.text = bestTime[0].ToString("F");
                break;

            default: break;
        }
               }

       
       
    /// <summary>
    /// Method to reset all values in the file and change displays 
    /// </summary>
    public void Reset()
    {
      deaths = new int[11] { 9999, 9999, 9999, 9999, 9999, 9999, 9999, 9999, 9999,9999,9999 };
      bestTime = new float[11] { 999.99f, 999.99f, 999.99f, 999.99f, 999.99f, 999.99f, 999.99f, 999.99f, 999.99f,999.99f,999.99f };
        if (deaths[1] == 9999) lvl1death.text = "N/A";
        else lvl1death.text = deaths[1].ToString();
        if (bestTime[1] == 999.99f) lvl1time.text = "N/A";
        else lvl1time.text = bestTime[1].ToString("F");
        if (deaths[2] == 9999) lvl2death.text = "N/A";
        else lvl2death.text = deaths[2].ToString();
        if (bestTime[2] == 999.99f) lvl2time.text = "N/A";
        else lvl2time.text = bestTime[2].ToString("F");
        if (deaths[3] == 9999) lvl3death.text = "N/A";
        else lvl3death.text = deaths[3].ToString();
        if (bestTime[3] == 999.99f) lvl3time.text = "N/A";
        else lvl3time.text = bestTime[3].ToString("F");
        if (deaths[4] == 9999) lvl4death.text = "N/A";
        else lvl4death.text = deaths[4].ToString();
        if (bestTime[4] == 999.99f) lvl4time.text = "N/A";
        else lvl4time.text = bestTime[4].ToString("F");
        if (deaths[5] == 9999) lvl5death.text = "N/A";
        else lvl5death.text = deaths[5].ToString();
        if (bestTime[5] == 999.99f) lvl5time.text = "N/A";
        else lvl5time.text = bestTime[5].ToString("F");
        if (deaths[6] == 9999) lvl6death.text = "N/A";
        else lvl6death.text = deaths[6].ToString();
        if (bestTime[6] == 999.99f) lvl6time.text = "N/A";
        else lvl6time.text = bestTime[6].ToString("F");
        if (deaths[7] == 9999) lvl7death.text = "N/A";
        else lvl7death.text = deaths[7].ToString();
        if (bestTime[7] == 999.99f) lvl7time.text = "N/A";
        else lvl7time.text = bestTime[7].ToString("F");
        if (deaths[8] == 9999) lvl8death.text = "N/A";
        else lvl8death.text = deaths[8].ToString();
        if (bestTime[8] == 999.99f) lvl8time.text = "N/A";
        else lvl8time.text = bestTime[8].ToString("F");
        if (deaths[9] == 9999) lvl9death.text = "N/A";
        else lvl9death.text = deaths[9].ToString();
        if (bestTime[9] == 999.99f) lvl9time.text = "N/A";
        else lvl9time.text = bestTime[9].ToString("F");
        if (deaths[10] == 9999) lvl10death.text = "N/A";
        else lvl10death.text = deaths[10].ToString();
        if (bestTime[10] == 999.99f) lvl10time.text = "N/A";
        else lvl10time.text = bestTime[10].ToString("F");
        if (deaths[0] == 9999) totalDeath.text = "N/A";
        else totalDeath.text = deaths[0].ToString();
        if (bestTime[0] == 999.99f) totalTime.text = "N/A";
        else totalTime.text = bestTime[0].ToString("F");
        Save();
    }
        /// <summary>
        /// Method to save the data to a file
        /// </summary>
    public void Save()
            {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/deaths.dat");

        DeathData data = new DeathData();
      
        j = 0;
        t = 0;
        for(int i = 0; i < 11; i++)
        {
            if (deaths[i] == 9999) j++;
        }
        for (int i = 0; i < 11; i++)
        {
            if (bestTime[i] == 999.99f) t++;
        }
        //Calculate the total deaths and time before saving
        bestTime[0] = bestTime[1] + bestTime[2] + bestTime[3] + bestTime[4] + bestTime[5] + bestTime[6] + bestTime[7] + bestTime[8] + bestTime[9] + bestTime[10] - (t * 999.99f);
        deaths[0] = deaths[1] + deaths[2] + deaths[3] + deaths[4] + deaths[5] + deaths[6] + deaths[7] + deaths[8] + deaths[9] + deaths[10] - (j * 9999);
        data.deaths = deaths;
        data.bestTime = bestTime;

        bf.Serialize(file, data);
        file.Close();
    }
    /// <summary>
    /// Method to load data from the file into variables.
    /// </summary>    
    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/deaths.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/deaths.dat", FileMode.Open);
            DeathData data = (DeathData)bf.Deserialize(file);
            deaths = data.deaths;
            bestTime = data.bestTime;

        }
    }

    }
/// <summary>
/// local class to be saved into file, must be serializable.
/// </summary>
[Serializable]
class DeathData
{
    public int[] deaths = new int[11];
    public float[] bestTime = new float[11];

}
