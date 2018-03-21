using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private bool IsPause = false;
    private int Inga = 1;

    [Header("Ingamemenü")]
    public GameObject Ingamemenü;

    private void Awake()
    {
        Ingamemenü.SetActive(false);
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleIngamemenü();
            ToggleTimeScale();
        }
    }
    void ToggleTimeScale()
    {
        if (!IsPause)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        IsPause = !IsPause;
    }

    private void ToggleIngamemenü()
    {
        if (Inga == 1)
        {
            Ingamemenü.SetActive(true);
            Inga = 0;
        }
        else
        {
            Ingamemenü.SetActive(false);
            Inga = 1;
        }
    }
}
