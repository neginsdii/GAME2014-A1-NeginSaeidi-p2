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
