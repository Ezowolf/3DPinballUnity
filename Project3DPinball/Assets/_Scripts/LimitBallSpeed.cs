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
		Debug.Log(rb.velocity.magnitude);
		if(rb.velocity.magnitude > maxSpeed)
		{
			Debug.Log("LIMIT!");
			rb.velocity = rb.velocity.normalized * maxSpeed;
		}
	}
}
