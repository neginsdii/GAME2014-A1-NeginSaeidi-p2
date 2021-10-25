/*
 * Full Name        : Negin Saeidi
 * Student ID       : 101261395
 * Date Modified    : October 20, 2021
 * File             : BladeFactory.cs
 * Description      : This is the blade Factory script - It instantiate the blades
 * Version          : V02
 * Revision History : Changed variable names, move function , added comments
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class BladeFactory : MonoBehaviour
{
    public GameObject blade;

    public GameObject createBullet()
    {
        GameObject temp_bullet = null;
        temp_bullet = Instantiate(blade);
        temp_bullet.transform.parent = transform;
        temp_bullet.SetActive(false);
        return temp_bullet;
    }
}
