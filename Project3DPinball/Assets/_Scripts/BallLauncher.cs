using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {
	public float minSize;
	public Vector3 startingSize = new Vector3(1,1,1);
	void Update () {
	if(Input.GetKey(KeyCode.Space))
	{
			if(transform.localScale.z>minSize)
			{
				transform.localScale += (new Vector3(0F, 0F, -0.5F)*(Time.deltaTime*100));
			}

	}
		else
		{
			if(transform.localScale.z<startingSize.z)
			{
				transform.localScale -= (new Vector3(0F, 0F, -0.5F)*(Time.deltaTime*100));
			}
		}

	}
}
