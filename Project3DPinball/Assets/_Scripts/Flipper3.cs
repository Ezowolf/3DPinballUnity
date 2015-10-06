using UnityEngine;
using System.Collections;

public class Flipper3 : MonoBehaviour
{
	public float restPosition = 0F;
	public float pressedPosition = 0F;
	public float flipperStrength = 3000F;
	public float flipperDamper = 1F;
	//public string inputButtonName = "LeftFlipper";
	
	void Awake ()
	{
		GetComponent<HingeJoint>().useSpring = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		JointSpring spring = new JointSpring();
		
		spring.spring = flipperStrength;
		spring.damper = flipperDamper;
		
		if (Input.GetKeyDown ("space")) {
			spring.targetPosition = pressedPosition;
		} else {
			spring.targetPosition = restPosition;
		}
		
		GetComponent<HingeJoint>().spring = spring;
	}
}
