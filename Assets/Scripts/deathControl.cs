using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathControl : MonoBehaviour {
    [SerializeField] private Text uiText;
    [SerializeField] private int mainDeaths;

    /// <summary>
    /// Creating a death counter and an object to be able to display such number
    /// </summary>
    public int deaths;
    public Text deathText;

    /// <summary>
    /// Allowing the starting variable to be accessed through Unity
    /// </summary>
    void Start()
    {
        deaths = mainDeaths;
    }

    /// <summary>
    /// Adding the amount of deaths
    /// </summary>
    public void upDeaths()
    {
        deaths += 1;
        uiText.text = deaths.ToString();
    }

}
