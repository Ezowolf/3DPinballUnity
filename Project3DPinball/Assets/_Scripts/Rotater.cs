using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {

	void Update() {
		transform.Rotate(Vector3.up * Time.deltaTime*30);
	}
}
