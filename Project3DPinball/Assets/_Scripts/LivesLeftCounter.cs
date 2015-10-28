using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LivesLeftCounter : MonoBehaviour {

	public int ballLives = 3;
	public Text textToDisplayLives;
	
	void Start()
	{
		UpdateTheLivesUI();
	}

	public void UpdateTheLivesUI()
	{
		textToDisplayLives.text = "Lives: "+ballLives;
	}
}
