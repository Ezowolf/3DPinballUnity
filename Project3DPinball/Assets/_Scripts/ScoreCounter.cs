using UnityEngine;
using System.Collections;

public class ScoreCounter : MonoBehaviour {

	private int myScore = 0;
	public ScoreUIUpdater myUIUpdater;

	void AddExtraScore(){
		myScore = myScore + 100;
		myUIUpdater.updateTheUI(myScore);
	}

	void Update(){
		AddExtraScore();
	}
}
