using UnityEngine;
using System.Collections;

public class seatControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Animator ani = this.GetComponent<Animator> ();
		ani.SetBool ("inUse", true);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.J)) {
			rotateSeat ();
		}
	}

	void onMouseUp () {
		Debug.Log ("Clicked on chair seat");
		rotateSeat ();
	}

	void rotateSeat() {
		Animator ani = this.GetComponent<Animator> ();
		ani.SetBool ("inUse", !ani.GetBool ("inUse"));
		ani.SetTrigger ("Triggered");
	}
}
