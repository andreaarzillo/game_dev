using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPage : MonoBehaviour
{
   [SerializeField]
    private GameObject GameUI;


    public void StartGame(){
        gameObject.SetActive(false);
        GameUI.SetActive(true);
        Messenger.Broadcast(GameEvent.START_GAME, MessengerMode.DONT_REQUIRE_LISTENER);
    }

   public void InfoGame(){
      
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
