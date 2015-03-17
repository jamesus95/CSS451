using UnityEngine;
using System.Collections;

public class SlideLeft : MonoBehaviour {

    private static readonly float moveDist = 25f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Slides item to the left when clicked on
    void OnMouseUp()
    {
        Vector3 cur = this.transform.position;
        Debug.Log(cur);
        Vector3 move = this.transform.right;
        Debug.Log(move);
        cur += move * moveDist * -1;
        this.transform.position = cur;
    }
}
