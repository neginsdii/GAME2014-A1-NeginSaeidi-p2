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
