using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spiel_verlassen : MonoBehaviour {

    
	// Update is called once per frame
	void Update () {
	    
	}
    public void Ingamemenü()
    {
        SceneManager.LoadScene("Startseite", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Startscene");
        SceneManager.UnloadSceneAsync("Ingamemenü");
    }
}
