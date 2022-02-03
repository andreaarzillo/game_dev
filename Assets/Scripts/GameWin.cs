using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{
    [SerializeField] private GameObject CanvasWin;
    [SerializeField] private GameObject GameUI;
    [SerializeField] private GameObject cameraUI;

    void Start()
    {
        Messenger.AddListener(GameEvent.GAME_WIN, DisplayGameWin);
    }


    private void DisplayGameWin()
    {
        //Debug.Log("OK");
        cameraUI.SetActive(true);
        GameUI.SetActive(false);
        PauseControl.Instance.PauseGame(false);
        GameManager.Instance.InputInteraction = true;
        CanvasWin.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    }
}