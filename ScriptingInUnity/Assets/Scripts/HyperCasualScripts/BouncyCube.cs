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
	
	
	void Start ()
	{
		squareRigidBody = GetComponent<Rigidbody>();
	}
	
	
	void Update ()
	{
	
		Vector3 direction = (target.position - Cube.transform.position)normalized;
		Cube.rigidbody.AddForce(direction * 250f);

		

		//transform.Translate(moveX, 0f, moveZ);
		
		squareRigidBody.AddForce(speed, 0, speed);
	}
}
