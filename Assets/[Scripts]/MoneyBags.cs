/*
 * Full Name        : Negin Saeidi
 * Student ID       : 101261395
 * Date Modified    : October 20, 2021
 * File             : MoneyBags.cs
 * Description      : This is the MoneyBags script - it controls the money bags object
 * Version          : V02
 * Revision History : Changed variable names, added comments
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyBags : MonoBehaviour
{
	// Start is called before the first frame update
	private void OnTriggerEnter2D(Collider2D collision)
	{

		if (collision.gameObject.tag == "Player")
		{
			if(Score.numOfBags>0)
			Score.numOfBags--;
			// gameObject.SetActive(false);
			Destroy(this.gameObject);
			Debug.Log("Collision");
		}
	}
}
