using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BladeManager : MonoBehaviour
{
    public Queue<GameObject> BladePool;
    public int BladeNumber;
    private BladeFactory factory;
    // Start is called before the first frame update
    void Start()
    {
        BladePool = new Queue<GameObject>();
        factory = GetComponent<BladeFactory>();

    }



    private void AddBlade()
    {
        var temp = factory.createBullet();
        BladePool.Enqueue(temp);
        BladeNumber++;
    }

    public GameObject getBullet(Vector2 position)
    {
        GameObject temp = null;
        if (BladePool.Count < 1)
        {
            AddBlade();
        }
        temp = BladePool.Dequeue();
        temp.transform.position = position;
        temp.SetActive(true);

        return temp;
    }

    public void ReturnBullet(GameObject reBullet)
    {
        reBullet.SetActive(false);
        BladePool.Enqueue(reBullet);

    }
}
