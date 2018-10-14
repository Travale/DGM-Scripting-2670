using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyCube : MonoBehaviour
{


	public float moveSpeed = 20f;
	private Rigidbody squareRigidBody;
	
	
	void Start ()
	{
		squareRigidBody = GetComponent<Rigidbody>();
	}
	
	
	void Update ()
	{
		float inputX = Input.GetAxis("Horizontal");
		float inputZ = Input.GetAxis("Vertical");

		float moveX = inputX * moveSpeed * Time.deltaTime;
		float moveZ = inputZ * moveSpeed * Time.deltaTime;

		//transform.Translate(moveX, 0f, moveZ);
		
		squareRigidBody.AddForce(moveX, 0f, moveZ);
	}
}
