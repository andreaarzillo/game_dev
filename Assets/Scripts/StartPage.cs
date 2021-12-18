using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class StartPage : MonoBehaviour
{

   [SerializeField]
   private GameObject GameUI;
   [SerializeField]
   private GameObject StartPanel;
   [SerializeField]
   private GameObject InfoPanel;
   [SerializeField]
   private InputField Username;
    [SerializeField]
   private GameObject Mondo;

    public void StartGame(){
        gameObject.SetActive(false);
        GameUI.SetActive(true);
        setUsername();
        Messenger.Broadcast(GameEvent.START_GAME, MessengerMode.DONT_REQUIRE_LISTENER);
        Mondo.SetActive(true);
    }



   public void InfoGame(){
      StartPanel.SetActive(false);
      InfoPanel.SetActive(true);
    }

    public void backToMainStart(){
      InfoPanel.SetActive(false);
      StartPanel.SetActive(true);

    }

    public void setUsername(){
      string username = Username.text;
      GameManager.Instance.PlayerName = username;


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
