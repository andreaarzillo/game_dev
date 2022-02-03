using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour
{
    private bool _gamePaused;
    public static PauseControl Instance = null;
    [SerializeField]
    private GameObject fpsCounter;

    void Awake()
    {
        // singleton routine
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        _gamePaused = false;
    }

    public void PauseGame(bool pause)
    {
        if (pause)
        {
            Time.timeScale = 0f;
            fpsCounter.SetActive(false);
        }
        else
        {
            Time.timeScale = 1;
            fpsCounter.SetActive(true);
        }

        _gamePaused = pause;
    }
}