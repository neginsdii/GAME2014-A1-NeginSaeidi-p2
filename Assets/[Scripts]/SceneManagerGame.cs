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
using UnityEngine.SceneManagement;

public class SceneManagerGame : MonoBehaviour
{
    public void loadScene()
    {
        if(tag=="Main")
		{
            Score.numOfBags = Score.maxnumOfBags;
            ShieldsPanel.numOfSheilds = ShieldsPanel.MaxShields;
		}
        SceneManager.LoadScene(tag);
    }

    public void ExitGame()
	{
        Application.Quit();
	}
}
