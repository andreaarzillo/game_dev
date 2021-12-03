using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{
    [SerializeField]
    private GameObject CanvasWin;
    void Start()
    {
        
        Messenger.AddListener(GameEvent.GAME_WIN, DisplayGameWin);

    }


    private void DisplayGameWin(){
        //Debug.Log("OK");
        PauseControl.Instance.PauseGame(false);
        GameManager.Instance.InputInteraction = true;
        CanvasWin.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
