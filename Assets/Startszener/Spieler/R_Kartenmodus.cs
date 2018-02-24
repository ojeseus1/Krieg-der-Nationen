using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class R_Kartenmodus : MonoBehaviour {

    private int gamemenü = 0;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            Ingamemenü();

        }

    }
    void Ingamemenü()
    {
        if (gamemenü == 0)
        {
            SceneManager.LoadScene("Kartenmodus", LoadSceneMode.Additive);
            gamemenü = 1;
        }
        else
        {
            SceneManager.UnloadSceneAsync("Katenmodus");
            gamemenü = 0;
        }
    }
    
}
