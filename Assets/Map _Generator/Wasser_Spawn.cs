using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wasser_Spawn : MonoBehaviour {
    public Transform spawn_posision;
    public GameObject prefabe1;
    public int anzahl;
    private Vector3 posrand;
	
	void Start () {
        Invoke("spawnone", 2);
	}
    void spawnone()
    {
        for (int i = 0; i < anzahl; i++)
        {
            posrand = Random.insideUnitSphere * 5;
            Instantiate(prefabe1, spawn_posision.transform.position + posrand, prefabe1.transform.rotation);
        }
    }
}
