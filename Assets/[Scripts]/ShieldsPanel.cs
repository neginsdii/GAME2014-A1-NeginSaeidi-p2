using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShieldsPanel : MonoBehaviour
{
    public static int numOfSheilds = 2;
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
    }

   
}
