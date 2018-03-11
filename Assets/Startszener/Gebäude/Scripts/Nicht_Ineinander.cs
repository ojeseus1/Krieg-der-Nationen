using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nicht_Ineinander : MonoBehaviour {

    public List<Collider> triggers;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gebäude"))
            triggers.Add (other);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Gebäude"))
            triggers.Remove (other);
    }
}

