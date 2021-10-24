using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Animator anim;
    public Transform target;
    public Transform spawnPosition;
    public float Speed;
    public float followRange;
    public float attackRange;
    private BladeManager bladeManager;

    [Header("Bullets")]
    public Transform bulletSpawnLeft;
    public Transform bulletSpawnRight;
    public int frameDelay;
    // Start is called before the first frame update
    void Start()
    {
        bladeManager = GameObject.FindObjectOfType<BladeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) >= followRange)
        {
            if (transform.position == spawnPosition.position)
                anim.SetBool("IsWalking", false);
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, spawnPosition.position, Speed * Time.deltaTime);
                SetScale(spawnPosition);
            }

        }
        else if (Vector3.Distance(target.position, transform.position) <= followRange && Vector3.Distance(target.position, transform.position) >= attackRange)
            followPlayer();
        else if (Vector3.Distance(target.position, transform.position) < attackRange)
        {
            anim.SetBool("IsAttacking", true);
            fireBlade();
        }
    }

    public void followPlayer()
	{
        
        anim.SetBool("IsWalking", true);
        transform.position = Vector3.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
        SetScale(target);
    }

    private void SetScale(Transform trg)
	{
        if (transform.position.x < trg.position.x)
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        else
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x) * -1, transform.localScale.y, transform.localScale.z);

    }

    private void fireBlade()
	{
        if (Time.frameCount % frameDelay == 0)
        {
            if(transform.localScale.x>0)
            bladeManager.getBullet(bulletSpawnRight.position);
            else
            bladeManager.getBullet(bulletSpawnLeft.position);

        }
    }
}
