using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Esc_Ingamemenü : MonoBehaviour {

    private bool IsPause = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Ingamemenü", LoadSceneMode.Additive);
            ToggleTimeScale();
        }

	}

    void ToggleTimeScale()
    {
        if(!IsPause)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        IsPause = !IsPause;
    }
}
