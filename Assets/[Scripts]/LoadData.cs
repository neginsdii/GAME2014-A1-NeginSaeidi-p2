/*
 * Full Name        : Negin Saeidi
 * Student ID       : 101261395
 * Date Modified    : October 20, 2021
 * File             : LoadData.cs
 * Description      : This is the LoadData script - it saves the number of money bags
 * Version          : V02
 * Revision History : Changed variable names, added comments
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoadData : MonoBehaviour
{
    public Text MoneyBags;

    // Start is called before the first frame update
    void Start()
    {
        MoneyBags.text ="Money Bags: "+ PlayerPrefs.GetInt("MoneyBags").ToString();

    }
}
