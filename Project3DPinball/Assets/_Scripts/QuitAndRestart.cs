using UnityEngine;
using System.Collections;

public class QuitAndRestart : MonoBehaviour {
	void Update(){
	if(Input.GetKey(KeyCode.Q))
	{
		Application.Quit();
	}
	if(Input.GetKey(KeyCode.R))
	{
		Application.LoadLevel(Application.loadedLevel);
	}
	}
}
