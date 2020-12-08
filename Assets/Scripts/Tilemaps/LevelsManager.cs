﻿/*
 * Author: Matteo
 * Last Modified by: Matteo
 * Date Last Modified: 2020-04-14
 * Program Description: Manages the levels that are used in Game
 * Revision History:
 *      - Initial Setup
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsManager : MonoBehaviour
{
    private void Awake()
    {
        // Disable all the childrens
        if (!string.IsNullOrEmpty(GameController.currentLevel))
        {
            foreach (Transform child in transform)
                child.gameObject.SetActive(false);
        }

        var selectedLevel = GameController.currentLevel == "Tutorial" ? transform.GetChild(0) : transform.Find(GameController.currentLevel);

        selectedLevel.gameObject.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
