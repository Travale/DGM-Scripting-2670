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
		/*transform.Translate(Vector3.forward * Time.deltaTime * speed);
		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit hit;

		if (Physics.Raycast(ray, out hit, Time.deltaTime + .1f)){
			Vector3 reflectDir = Vector3.Reflect(ray.direction, hit.normal);
			float rot = 90 - Mathf.Atan2(reflectDir.x, reflectDir.x) * Mathf.Rad2Deg;
			transform.eulerAngles = new Vector3(0, rot, 0);*/
		}
	}
}
