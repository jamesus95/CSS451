using UnityEngine;
using System.Collections;

public class Remove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    // Deletes Item when clicked on
    void OnMouseUp()
    {
        Destroy(this.gameObject);
    }
}
