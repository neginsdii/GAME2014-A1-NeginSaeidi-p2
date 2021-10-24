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
			Score.numOfBags++;
			// gameObject.SetActive(false);
			Destroy(this.gameObject);
			Debug.Log("Collision");
		}
	}
}
