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
            SceneManager.LoadScene("LevelEndScene");
        }
    }

   
}
