using UnityEngine;
using System.Collections;

public class DissapearAfterScore : MonoBehaviour {

	public int scoreWhenDissapear = 2500;
	public ScoreCounter myScoreCounter;

	void Update () {
		if(myScoreCounter.myScore>=scoreWhenDissapear)
		{
			Destroy(gameObject);
		}
	}
}
