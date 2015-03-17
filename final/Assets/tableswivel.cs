using UnityEngine;
using System.Collections;

public class tableswivel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.G)) {
			HingeJoint hj = this.gameObject.GetComponent<HingeJoint>();
			JointSpring js = hj.spring;
			js.targetPosition = 90f;
			hj.spring = js;
		}
		if (Input.GetKeyDown(KeyCode.H)) {
			HingeJoint hj2 = this.gameObject.GetComponent<HingeJoint>();
			JointSpring js2 = hj2.spring;
			js2.targetPosition = 0f;
			hj2.spring = js2;
		}
	}

	void OnMouseDown() {
		HingeJoint hj = this.gameObject.GetComponent<HingeJoint>();
		JointSpring js = hj.spring;
		if (js.targetPosition == 0) {
			js.targetPosition = 90;
		} else {
			js.targetPosition = 0;
		}
		hj.spring = js;
	}
}
