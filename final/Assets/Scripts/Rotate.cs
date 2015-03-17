using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Rotates Item 90 degrees when clicked on
    void OnMouseUp()
    {
        this.transform.Rotate(this.transform.right,90f);
    }

}
