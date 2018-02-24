using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GebäudeController : MonoBehaviour {
    public LayerMask surfaceLayer;
    private Transform currentBilding;
    private Camera myCamera;
	// Use this for initialization
	void Start () {
        myCamera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (currentBilding !=null)
        {
            Ray ray = myCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit,Mathf.Infinity,surfaceLayer))
            {
                currentBilding.position = hit.point;
            }
            if (Input.GetMouseButtonDown (1))
            {
                currentBilding = null;
            }
        }
	}

    public void SetCurrentBuilding(GameObject building)
    {
        currentBilding = ((GameObject)Instantiate(building)).transform;
    }
}
