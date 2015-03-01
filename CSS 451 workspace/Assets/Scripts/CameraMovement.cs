using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    private static readonly float speed = 10f;

    private int y;      // ctrl/space
    private int x;      // q/e
    private int z;      // w/s
    private int turn;   // a/d

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnGUI()
    {
        if (Event.current != null)
        {
            // Return to rest when key is released
            if (Event.current.type.Equals(EventType.keyUp))
            {
                switch (Event.current.keyCode)
                {
                    case KeyCode.A:
                        turn = 0;
                        break;

                    case KeyCode.W:
                        z = 0;
                        break;

                    case KeyCode.D:
                        turn = 0;
                        break;

                    case KeyCode.S:
                        z = 0;
                        break;

                    case KeyCode.Space:
                        y = 0;
                        break;

                    case KeyCode.LeftControl:
                        y = 0;
                        break;

                    case KeyCode.Q:
                        x = 0;
                        break;

                    case KeyCode.E:
                        x = 0;
                        break;
                }
            }

            // move when key is pressed down
            else if (Event.current.type.Equals(EventType.keyDown))
            {
                switch (Event.current.keyCode)
                {
                    case KeyCode.A:
                        turn = -1;
                        break;

                    case KeyCode.W:
                        z = 1;
                        break;

                    case KeyCode.D:
                        turn = 1;
                        break;

                    case KeyCode.S:
                        z = -1;
                        break;

                    case KeyCode.Space:
                        y = 1;
                        break;

                    case KeyCode.LeftControl:
                        y = -1;
                        break;

                    case KeyCode.Q:
                        x = -1;
                        break;

                    case KeyCode.E:
                        x = 1;
                        break;
                }
            }

            // Move camera
            Vector3 movement = new Vector3();
            movement += this.transform.right * x * speed * Time.smoothDeltaTime;
            movement += this.transform.forward * z * speed * Time.smoothDeltaTime;
            movement += this.transform.up * y * speed * Time.smoothDeltaTime;
            this.transform.position += movement;

            // turn camera
            switch (turn)
            {
                case 1:
                    this.transform.Rotate(Vector3.up);
                    break;

                case -1:
                    this.transform.Rotate(Vector3.down);
                    break;
            }
        }
    }

}
