using UnityEngine;
using System.Collections;

public class MouseRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(this.transform.up, -90f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(this.transform.up, 90f);
        }
    }
}
