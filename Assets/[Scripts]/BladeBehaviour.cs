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
    [SerializeField]
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        bladeManager = GameObject.FindObjectOfType<BladeManager>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Velocity = (target.transform.position - transform.position).normalized * Speed;

        Move();
    }
    private void Move()
    {

        transform.position += Velocity;
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
      //  bladeManager.ReturnBullet(this.gameObject);
    }
}
