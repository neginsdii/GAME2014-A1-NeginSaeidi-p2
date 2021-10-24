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
