using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DeathPit : MonoBehaviour {
	private bool haveIDestroyedBall = false;

	public AudioSource soundWhenBallDestroys;
	public Text gameOverText;
	
	void Start()
	{
		gameOverText.text = "";
	}
	void OnCollisionEnter(Collision collision) 
	{
		if(collision.gameObject.tag == "BallTag")
		{
			GameOver(collision);
		}
	}

	void GameOver(Collision objectToDestroy)
	{
		//check if you still have balls left?
		Destroy(objectToDestroy.gameObject);
		haveIDestroyedBall = true;
		soundWhenBallDestroys.Play();
		gameOverText.text = "GAME OVER";
	}
}
