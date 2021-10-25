/*
 * Full Name        : Negin Saeidi
 * Student ID       : 101261395
 * Date Modified    : October 20, 2021
 * File             : Score.cs
 * Description      : This is the Score script - keep track of monetbags in the scene
 * Version          : V02
 * Revision History : Changed variable names, added comments
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static int numOfBags = 16;
    public static int maxnumOfBags = 16;
    private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Bags: " + numOfBags;
        if(numOfBags==0)
        {
            PlayerPrefs.SetInt("MoneyBags", Score.maxnumOfBags - Score.numOfBags);
            SceneManager.LoadScene("LevelEndScene");
        }
    }

   
}
