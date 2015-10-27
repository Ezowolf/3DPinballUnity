using UnityEngine;
using System.Collections;

public class LimitBallSpeed : MonoBehaviour {
	public float maxSpeed = 200f;
	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate()
	{
		if(rb.velocity.magnitude > maxSpeed)
		{
			rb.velocity = rb.velocity.normalized * maxSpeed;
		}
	}
}
