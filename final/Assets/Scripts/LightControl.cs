using UnityEngine;
using System.Collections;


// Place on switches that are named (closeSwitch, farSwitch, and smallSwitch)
// Name groups of lights (boxLightClose, boxLightFar, smallLights) NOT INDIVIDUAL LIGHTS
// code will get all children of the object you name
public class LightControl : MonoBehaviour {

    ArrayList boxLightClose = new ArrayList();
    ArrayList boxLightFar = new ArrayList();
    ArrayList smallLights = new ArrayList();

	// Use this for initialization
	void Start () {
        //GameObject[] temp = GameObject.FindGameObjectsWithTag("boxLightClose");
        //foreach (GameObject o in temp) {
        //    boxLightClose.AddRange(o.GetComponentsInChildren<Light>());
        //}
        GameObject[] temp = GameObject.FindGameObjectsWithTag("boxLightFar");
        foreach (GameObject o in temp)
        {
            boxLightFar.AddRange(o.GetComponentsInChildren<Light>());
        }
        temp = GameObject.FindGameObjectsWithTag("smallLights");
        foreach (GameObject o in temp)
        {
            smallLights.AddRange(o.GetComponentsInChildren<Light>());
        }
        Debug.Log(boxLightFar.Count + "   " + smallLights.Count);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("M");
            SwitchFar();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("N");
            SwitchSmall();
        }
        switch (this.gameObject.tag)
        {
            case "closeSwitch":
                SwitchClose();
                break;

            case "farSwitch":
                SwitchFar();
                break;

            case "smallSwitch":
                SwitchSmall();
                break;

        }
	}

    void SwitchClose()
    {
        foreach (Light l in boxLightClose)
        {
            l.enabled = !l.enabled;
        }
    }

    void SwitchFar()
    {
        foreach (Light l in boxLightFar)
        {
            l.enabled = !l.enabled;
        }
    }

    void SwitchSmall()
    {
        foreach (Light l in smallLights)
        {
            l.enabled = !l.enabled;
        }
    }
}
