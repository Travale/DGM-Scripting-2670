using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{


	public Rigidbody squareRigidBody;
	// Use this for initialization
	void Start () {
		
	}
	
	
	void Update ()
	{
		squareRigidBody.AddForce(transform.Translate(-3f, 0, -5f));
	}
}
