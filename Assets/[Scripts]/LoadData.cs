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
