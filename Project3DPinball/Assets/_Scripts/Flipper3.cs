using UnityEngine;
using System.Collections;

public class Flipper3 : MonoBehaviour {
	
	public enum Side {
		left,
		right
	};
	public Side side;	
	public float speed = 100f;
	public HingeJoint hingeJoint;
	
	float _maxAngle = 60f;
	JointSpring spring = new JointSpring();
	
	float _targetAngle;
	
	void Awake () {
		hingeJoint.useSpring = true;
	}
	
	void Start() {
		spring.spring = speed;
		spring.damper = 1f;
		
		HingeJoint hinge = gameObject.GetComponent<HingeJoint> ();
		_maxAngle = hinge.limits.max;

		if (side == Side.left)
			hinge.axis = Vector3.down;
		else
			hinge.axis = Vector3.up;
	}
	
	void FixedUpdate() {
		if ((side == Side.right && Input.GetKey(KeyCode.RightArrow))
		    || (side == Side.left && Input.GetKey(KeyCode.LeftArrow)))
				spring.targetPosition = _maxAngle;

		else
			spring.targetPosition = 0f;
		
		hingeJoint.spring = spring;
	}
}