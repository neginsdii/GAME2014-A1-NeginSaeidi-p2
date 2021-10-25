/*
 * Full Name        : Negin Saeidi
 * Student ID       : 101261395
 * Date Modified    : October 20, 2021
 * File             : SavaData.cs
 * Description      : This is the SavaData script - save the amoubt of bags collected by the player
 * Version          : V02
 * Revision History : Changed variable names, added comments
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SavaData : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("MoneyBags", Score.maxnumOfBags - Score.numOfBags);

    }

    
}
