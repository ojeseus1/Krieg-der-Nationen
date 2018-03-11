using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GebäudeController : MonoBehaviour {
    public LayerMask surfaceLayer;
    private Transform currentBuilding;
    private Camera myCamera;
	// Use this for initialization
	void Start () {
        myCamera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (currentBuilding !=null)
        {
            Ray ray = myCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit,Mathf.Infinity,surfaceLayer))
            {
                currentBuilding.position = hit.point;
            }
            if (Input.GetMouseButtonDown (1))
            {
                if(currentBuilding.GetComponent<Nicht_Ineinander>().triggers.Count == 0)
                currentBuilding = null;
            }
        }
	}

    public void SetCurrentBuilding(GameObject building)
    {
        currentBuilding = ((GameObject)Instantiate(building)).transform;
    }
}
