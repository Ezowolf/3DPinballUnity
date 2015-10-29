using UnityEngine;
using System.Collections;

public class AddForceToBall : MonoBehaviour {
	private bool canIBeLaunched = false;
	public float launchForce = 9999;
	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	void Update () {
		if (Input.GetKeyUp("space")&&canIBeLaunched==true)
		{
			canIBeLaunched = false;
			rb.velocity = new Vector3(0,0,launchForce);

		}
}
	void OnCollisionEnter(Collision coll)
	{
		if(coll.gameObject.tag=="SpringTag")
		{
			canIBeLaunched = true;
		}
	}
}
