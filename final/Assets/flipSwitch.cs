using UnityEngine;
using System.Collections;

public class flipSwitch : MonoBehaviour {

	public bool isOn;	// current state

	// Use this for initialization
	void Start () {
		isOn = true;	// room default to light
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.N)) {
			flip ();

		}
	}

	void OnMouseDown() {
		flip ();
	}

	public void flip() {
		isOn = !isOn;	// change internal state

		// change the orientation of the switch
		float xRotate = 45;
		if (isOn) {
			xRotate = -45;
		}
		this.transform.localEulerAngles = new Vector3(xRotate, 270, 90);

		// TODO: change the light states
		// James already did independently

	}
}
