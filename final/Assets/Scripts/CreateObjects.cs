using UnityEngine;
using System.Collections;

public class CreateObjects : MonoBehaviour {

    private static readonly float createDist = 100f;
    private GameObject cube;
    private GameObject sphere;
    private GameObject pyramid;

	// Use this for initialization
	void Start () {
        cube = (GameObject)Resources.Load("Cube");
        pyramid = (GameObject)Resources.Load("Pyramid");
        sphere = (GameObject)Resources.Load("Sphere");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // called when button pressed

    // makes cube
    void CreateCube()
    {
        Instantiate(cube, GetPosition(), this.transform.rotation);
    }

    // makes sphere
    void CreateSphere()
    {
        Instantiate(sphere, GetPosition(), this.transform.rotation);
    }

    // makes pyramid
    void CreatePyramid()
    {
        Instantiate(pyramid, GetPosition(), this.transform.rotation);
    }

    // gets user camera position
    Vector3 GetPosition()
    {
        Vector3 pos = this.transform.position;
        pos += this.transform.forward * createDist;
        return pos;
    }

}
