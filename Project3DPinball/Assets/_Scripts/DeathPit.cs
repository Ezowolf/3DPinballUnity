using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DeathPit : MonoBehaviour {

	public AudioSource soundWhenBallDestroys;
	public Text gameOverText;
	public LivesLeftCounter myLivesCounter;
	
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
		soundWhenBallDestroys.Play();
		if(myLivesCounter.ballLives==1)
		{
			Destroy(objectToDestroy.gameObject);
			gameOverText.text = "GAME OVER";
		}
		else
		{
			objectToDestroy.transform.position = new Vector3(11F,2.077F,5F);
			myLivesCounter.ballLives--;
			myLivesCounter.UpdateTheLivesUI();
		}
	}
}
