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
