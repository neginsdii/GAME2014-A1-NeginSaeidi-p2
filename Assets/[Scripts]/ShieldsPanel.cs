/*
 * Full Name        : Negin Saeidi
 * Student ID       : 101261395
 * Date Modified    : October 20, 2021
 * File             : ShieldsPanel.cs
 * Description      : This is the ShieldsPanel script - Keeps track of shields in the scene
 * Version          : V02
 * Revision History : Changed variable names, added comments
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ShieldsPanel : MonoBehaviour
{
    public static int numOfSheilds = 3;
    public static int MaxShields = 3;

    public Image[] shields;
    public Sprite shield;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < shields.Length; i++)
        {
            if (i < numOfSheilds)
                shields[i].enabled = true;
            else
            {
                shields[i].enabled = false;

            }
        }
        if(numOfSheilds==0)
        {
            PlayerPrefs.SetInt("MoneyBags", Score.maxnumOfBags - Score.numOfBags);
            SceneManager.LoadScene("GameoverScene");
        }

    }

   
}
