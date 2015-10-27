using UnityEngine;
using System.Collections;

public class AddForceToBall : MonoBehaviour {
	private bool canIBeLaunched = true;
	public float launchForce;
	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	void Update () {
		if (Input.GetKeyUp("space")&&canIBeLaunched==true)
		{
			canIBeLaunched = false;
			rb.AddForce(transform.forward * launchForce );

		}
}
}
