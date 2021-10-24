using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    public Transform playerTransform;
    public float speed;
    private bool touchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;

    public Animator anim;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
		{
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
  

        }
        if (Input.GetMouseButton(0))
		{
            touchStart = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            if (pointB.x > playerTransform.position.x)
                playerTransform.localScale = new Vector3(Mathf.Abs(playerTransform.localScale.x), playerTransform.localScale.y, playerTransform.localScale.z);
            else
                playerTransform.localScale = new Vector3(Mathf.Abs(playerTransform.localScale.x) * -1, playerTransform.localScale.y, playerTransform.localScale.z);

        }
        else
		{
            touchStart = false;
		}
    }

	private void FixedUpdate()
	{
		if(touchStart)
		{
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            MoveCharacter(direction);
            anim.SetBool("IsWalking", true);
       	}
        else
		{
            anim.SetBool("IsWalking", false);

        }

    }
	void MoveCharacter ( Vector2 direction)
	{
        playerTransform.Translate(direction * speed * Time.deltaTime);
	}

	
}
