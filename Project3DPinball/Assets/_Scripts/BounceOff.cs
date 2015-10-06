using UnityEngine;
using System.Collections;

public class BounceOff : MonoBehaviour {

	private Rigidbody myRB;

	void Start()
	{
		myRB = GetComponent<Rigidbody>();
	}

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "ExtraScoreBumper")
		{
			Debug.Log("miep");
		}
	}
}
