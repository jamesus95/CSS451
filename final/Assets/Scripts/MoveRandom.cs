using UnityEngine;
using System.Collections;

public class MoveRandom : MonoBehaviour {

    private float moveDist = 40f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        System.Random r = new System.Random();
        int rl = r.Next(-1, 2);
        int ud = r.Next(-1, 2);
        int fb = r.Next(-1, 2);
	    if (Input.GetMouseButtonDown(1)) {
            Vector3 cur = this.transform.position;
            Vector3 move = new Vector3();
            move.x = rl * moveDist;
            move.y = ud * moveDist;
            move.z = fb * moveDist;
            cur += move;
            this.transform.position = cur;
        }
	}


}
