using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour {

	public enum Side {
		Right, 
		Left
	};
	public Side side;
	private float Force = 10;

	// Use this for initialization
	void Start () {
		if(Input.GetKeyDown(KeyCode.A)){
			//this.GetComponent<Rigidbody>().AddForce(transform.forward * Force, ForceMode.Impulse);
			Debug.Log ("Dit werkt");
		}
		else{
			this.GetComponent<Rigidbody>().AddForce((transform.forward * Force) * -1, ForceMode.Impulse);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
