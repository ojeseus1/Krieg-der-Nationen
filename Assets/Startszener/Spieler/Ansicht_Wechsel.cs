using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ansicht_Wechsel : MonoBehaviour {

    public Camera kamera1;
    public Camera kamera2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            kamera1.enabled = !kamera1.enabled;
            kamera2.enabled = !kamera2.enabled;
        }
    }
}
