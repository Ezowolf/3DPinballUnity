using UnityEngine;
using System.Collections;

public class BounceOff : MonoBehaviour {
	private float bounceOffPower;

	private Rigidbody myRB;

	void Start()
	{
		myRB = GetComponent<Rigidbody>();
	}

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "ExtraScoreBumper")
		{
			bounceOffPower = Random.Range(-10F, -25F);
			myRB.velocity = myRB.velocity * bounceOffPower;
		}
	}
}
