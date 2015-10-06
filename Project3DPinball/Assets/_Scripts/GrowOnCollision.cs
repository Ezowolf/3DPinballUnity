using UnityEngine;
using System.Collections;

public class GrowOnCollision : MonoBehaviour {
	private Vector3 startingSize = new Vector3(1,1,1);
	void OnCollisionStay(Collision coll)
	{
		if(transform.localScale.x<2)
		{
		transform.localScale += (new Vector3(0.5F, 0.5F, 0.5F)*(Time.deltaTime*15));
		}
		else
		{
		transform.localScale = startingSize;
		}

	}
	

}
