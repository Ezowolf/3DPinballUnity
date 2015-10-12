using UnityEngine;
using System.Collections;

public class DeathPit : MonoBehaviour {
	private bool haveIDestroyedBall = false;

	public AudioSource soundWhenBallDestroys;

	void OnCollisionEnter(Collision collision) 
	{
		if(collision.gameObject.tag == "BallTag")
		{
			Destroy(collision.gameObject);
			haveIDestroyedBall = true;
			soundWhenBallDestroys.Play();
		}
	}
}
