using UnityEngine;
using System.Collections;

public class GrowOnCollision : MonoBehaviour {
	public float maxSize;
	public Vector3 startingSize = new Vector3(1,1,1);
	void OnCollisionStay(Collision coll)
	{
		if(transform.localScale.x<maxSize)
		{
		transform.localScale += (new Vector3(0.5F, 0.5F, 0.5F)*(Time.deltaTime*20));
		}
		else
		{
			transform.localScale = startingSize;
		}
	}

	void OnCollisionExit(Collision coll)
	{
		transform.localScale = startingSize;
	}
	

}
