using UnityEngine;
using System.Collections;

public class ScoreCounter : MonoBehaviour {

	private int myScore = 0;
	public ScoreUIUpdater myUIUpdater;
	public AudioSource soundWhenExtraScore;

	void AddExtraScore(){
		myScore = myScore + 100;
		soundWhenExtraScore.Play();
		myUIUpdater.updateTheUI(myScore);
	}

	void Update(){
		AddExtraScore();
	}
}
