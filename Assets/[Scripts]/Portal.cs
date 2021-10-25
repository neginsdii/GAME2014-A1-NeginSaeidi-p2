/*
 * Full Name        : Negin Saeidi
 * Student ID       : 101261395
 * Date Modified    : October 20, 2021
 * File             : Portal.cs
 * Description      : This is the Portal script - changes the position of the player upon colliding with this object
 * Version          : V02
 * Revision History : Changed variable names, added comments
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject Player;
    public GameObject portal;
    public float range;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.tag=="Player")
		{
                StartCoroutine(Teleport());
		}
	}

    IEnumerator Teleport()
	{
        yield return new WaitForSeconds(1);
        Player.transform.position =  new Vector3( portal.transform.position.x-range, portal.transform.position.y, portal.transform.position.z);
	}
}
