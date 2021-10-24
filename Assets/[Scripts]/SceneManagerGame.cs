using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerGame : MonoBehaviour
{
    public void loadScene()
    {
        SceneManager.LoadScene(tag);
    }

    public void ExitGame()
	{
        Application.Quit();
	}
}
