using UnityEngine;
using System.Collections;

public class projectorSlide : MonoBehaviour {

	public bool inUse;
	public float easeFactor = 15f;

	// Use this for initialization
	void Start () {
		inUse = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.G)) {
			inUse = !inUse;

			if(inUse) {
				// roll it down by 7.5 y
				// float yDisp = (float) 7.5 * easeFactor * Time.deltaTime;
				float yDisp = (float) 7.5;
				this.transform.Translate(new Vector3(0, yDisp, 0));
			}
		}
	}
}
