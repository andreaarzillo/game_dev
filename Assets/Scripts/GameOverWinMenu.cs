using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverWinMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject StartPage;
     [SerializeField]
    private GameObject UserUI;
    [SerializeField]
    private GameObject world;

     public void Exit()
    {
        gameObject.SetActive(false);
        PauseControl.Instance.PauseGame(false);
        GameManager.Instance.InputInteraction = true;
        Messenger.Broadcast(GameEvent.START_PAGE, MessengerMode.DONT_REQUIRE_LISTENER);
        UserUI.SetActive(false);
        world.SetActive(false);
        StartPage.SetActive(true);

        //TODO scermata menu principale

    }


    public void Replay(){
        
        gameObject.SetActive(false);
        UserUI.SetActive(true);
        PauseControl.Instance.PauseGame(false);
        GameManager.Instance.InputInteraction = true;
        Messenger.Broadcast(GameEvent.RESET_GAME, MessengerMode.DONT_REQUIRE_LISTENER);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
