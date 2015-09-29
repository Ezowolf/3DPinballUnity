using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreUIUpdater : MonoBehaviour {
	public Text textToDisplayScore;
		
	public void updateTheUI(int newScore)
	{
		textToDisplayScore.text = "Score: "+newScore;
	}
}
