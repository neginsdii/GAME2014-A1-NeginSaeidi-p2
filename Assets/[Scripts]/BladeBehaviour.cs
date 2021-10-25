/*
 * Full Name        : Negin Saeidi
 * Student ID       : 101261395
 * Date Modified    : October 20, 2021
 * File             : BladeBehaviour.cs
 * Description      : This is the blade behaviour script - It makes the blade moves towards the player
 * Version          : V02
 * Revision History : Changed variable names , added comments
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeBehaviour : MonoBehaviour
{
    [Header("Bullet Movement")]
    [Range(0.0f, 0.5f)]
    public float Speed;
    public Bounds bladeBounds;

    private BladeManager bladeManager;
    private Vector3 Velocity;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        bladeManager = GameObject.FindObjectOfType<BladeManager>();
        target = GameObject.FindGameObjectWithTag("Player");
        Velocity = (target.transform.position - transform.position).normalized * Speed;
    }

    // Update is called once per frame
    void Update()
    {

        Move();
    }
    private void Move()
    {

        transform.position += Velocity;
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.gameObject.tag == "Player")
        {
            bladeManager.ReturnBullet(this.gameObject);
            if(ShieldsPanel.numOfSheilds>0)
            ShieldsPanel.numOfSheilds--;
        }
        //if (collision.gameObject.tag == "Wall")
        //{
        //    bladeManager.ReturnBullet(this.gameObject);

        //}
    }
}
