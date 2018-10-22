using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class BouncyCube : MonoBehaviour
{
	public float force;
	public float speed = 7f;
	public float moveSpeed = 20f;
	private Rigidbody squareRigidBody;
	public Random randomSpeed = new Random();
	public bool moveDirection;
	public LayerMask whatIsWall;
	private bool collideWithWall;
	public Transform wallCheck;
	
	void Start ()
	{
		squareRigidBody = GetComponent<Rigidbody>();
	}
	
	
	void Update ()
	{
		collideWithWall = Physics2D.OverlapCircle(wallCheck.position, 5f, whatIsWall);

		if (collideWithWall)
			moveDirection = !moveDirection;

		if (moveDirection)
		{
			transform.localScale = new Vector3(3f, 0f, 5f);
			squareRigidBody.velocity = new Vector2(moveSpeed, squareRigidBody.velocity.x);
		}
		else
		{
			transform.localScale = new Vector3(-3f, 0f, -5f);
			squareRigidBody.velocity = new Vector2(-moveSpeed, squareRigidBody.velocity.x);
		}
		//transform.Translate(moveX, 0f, moveZ);
		
		
	}
}
