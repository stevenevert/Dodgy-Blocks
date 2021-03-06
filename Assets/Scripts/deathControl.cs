﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathControl : MonoBehaviour {

    /// <summary>
    /// Creating objects and vars to be able to hold the death count value and to access the UI through Unity
    /// </summary>
    [SerializeField] private Text uiText;
    [SerializeField] private int mainDeaths;

    /// <summary>
    /// Creating a death counter and an object to be able to display such number
    /// </summary>
    public static int deaths;
    public Text deathText;

    /// <summary>
    /// Allowing the starting variable to be accessed through Unity
    /// </summary>
    void Start()
    {
        deaths = mainDeaths;
    }

    /// <summary>
    /// Adding the amount of deaths and displaying such
    /// </summary>
    public void upDeaths()
    {
        deaths += 1;
        uiText.text = deaths.ToString();
    }

}
