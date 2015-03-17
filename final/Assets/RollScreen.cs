using UnityEngine;
using System.Collections;

public class RollScreen : MonoBehaviour {

	public bool isUp;

	// Use this for initialization
	void Start () {
		isUp = false; 	// screen default to being rolled down
		Animator ani = this.GetComponent<Animator>();
		ani.SetBool("Triggered", false);
		ani.SetBool ("RollUp", false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.K)) {
			launchAnimation();
		}
	}

	public void launchAnimation() {
		Animator ani = this.GetComponent<Animator>();
		
		ani.SetTrigger("Triggered-t");
		
		ani.SetBool("RollUp", !ani.GetBool("RollUp"));
		isUp = !isUp;
	}


}
