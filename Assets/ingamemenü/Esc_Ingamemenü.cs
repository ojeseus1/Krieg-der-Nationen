using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Esc_Ingamemenü : MonoBehaviour {

    private bool IsPause = false;
    private int gamemenü = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Ingamemenü();
            ToggleTimeScale();
        }

	}
    void Ingamemenü()
    {
        if(gamemenü == 0)
        {
            SceneManager.LoadScene("Ingamemenü", LoadSceneMode.Additive);
            gamemenü = 1;
        }
        else
        {
            SceneManager.UnloadSceneAsync("Ingamemenü");
            gamemenü = 0;
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
