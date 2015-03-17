using UnityEngine;
using System.Collections;

public class LightControl : MonoBehaviour {

    ArrayList boxLightClose = new ArrayList();
    ArrayList boxLightFar = new ArrayList();
    ArrayList smallLights = new ArrayList();

	// Use this for initialization
	void Start () {
        GameObject[] temp = GameObject.FindGameObjectsWithTag("boxLightClose");
        foreach (GameObject o in temp) {
            boxLightClose.AddRange(o.GetComponentsInChildren<Light>());
        }
        temp = GameObject.FindGameObjectsWithTag("boxLightFar");
        foreach (GameObject o in temp)
        {
            boxLightFar.AddRange(o.GetComponentsInChildren<Light>());
        }
        temp = GameObject.FindGameObjectsWithTag("smallLights");
        foreach (GameObject o in temp)
        {
            smallLights.AddRange(o.GetComponentsInChildren<Light>());
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SwitchClose(bool on)
    {
        foreach (Light l in boxLightClose)
        {
            l.enabled = on;
        }
    }

    void SwitchFar(bool on)
    {
        foreach (Light l in boxLightFar)
        {
            l.enabled = on;
        }
    }

    void SwitchSmall(bool on)
    {
        foreach (Light l in smallLights)
        {
            l.enabled = on;
        }
    }
}
