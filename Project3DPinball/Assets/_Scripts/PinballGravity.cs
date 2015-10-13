using UnityEngine;
using System.Collections;

public class PinballGravity : MonoBehaviour {
	public Vector3 myGravity;
	
	void Start () {
		Physics.gravity = myGravity;
	}
}
