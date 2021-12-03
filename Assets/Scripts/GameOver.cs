using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject GameOverCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Messenger.AddListener(GameEvent.GAME_OVER, DisplayGameOver);

    }

    private void DisplayGameOver(){
        //Debug.Log("OK");
        PauseControl.Instance.PauseGame(false);
        GameManager.Instance.InputInteraction = true;
        GameOverCanvas.SetActive(true);

    }
}
