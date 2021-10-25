/*
 * Full Name        : Negin Saeidi
 * Student ID       : 101261395
 * Date Modified    : October 20, 2021
 * File             : Shield.cs
 * Description      : This is the Shield script - Controls the shield object
 * Version          : V02
 * Revision History : Changed variable names, added comments
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		
			if (collision.gameObject.tag =="Player")
			{
				if (ShieldsPanel.numOfSheilds < ShieldsPanel.MaxShields)
				{
					ShieldsPanel.numOfSheilds++;
				}
				Destroy(this.gameObject);

			}
		}
	
}
