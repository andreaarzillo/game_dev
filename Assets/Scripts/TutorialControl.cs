using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialControl : MonoBehaviour
{

     [SerializeField]
    private GameObject TututorialKeys;
    [SerializeField]
    private GameObject TutorialUI;
     [SerializeField]
    private GameObject TutorialUI_Menu;
     [SerializeField]
    private GameObject TutorialUI_Energy;
     [SerializeField]
    private GameObject TutorialUI_Life;
    [SerializeField]
    private GameObject TutorialUI_Timer;
    [SerializeField]
   private GameObject GameUI;
   [SerializeField]
   private GameObject Mondo;
    [SerializeField]
   private GameObject Tutorial;
   public GameObject CameraUI;
   public GameObject Camera1;
    // Start is called before the first frame update
    int nrNext;
    bool started = false;
    void Start()
    {
        nrNext = 0;
        started = true;

        Messenger.AddListener(GameEvent.START_TUTORIAL, startTutorial);

    }

    private void startTutorial(){
        if(nrNext==0){
            Tutorial.SetActive(true);
            TututorialKeys.SetActive(true);
            started = true;

        }else{
            TututorialKeys.SetActive(false);
                TutorialUI_Menu.SetActive(false);
                TutorialUI_Energy.SetActive(false);
                TutorialUI_Life.SetActive(false);
                TutorialUI_Timer.SetActive(false);
                TutorialUI.SetActive(false);
                Tutorial.SetActive(false);
                GameUI.SetActive(true);
                Mondo.SetActive(true);
                Camera1.SetActive(true);
                CameraUI.SetActive(false);
                Messenger.Broadcast(GameEvent.START_GAME, MessengerMode.DONT_REQUIRE_LISTENER);

        }
        

    }

    public void pushNext(){
        switch(nrNext) 
        {
            case 0:
                TututorialKeys.SetActive(false);
                TutorialUI.SetActive(true);
                nrNext++;
            break;
            case 1:
                TutorialUI_Menu.SetActive(false);
                TutorialUI_Energy.SetActive(true);
                nrNext++;
            break;
            case 2:
                TutorialUI_Energy.SetActive(false);
                TutorialUI_Life.SetActive(true);
                nrNext++;
            break;
            case 3:
                TutorialUI_Life.SetActive(false);
                TutorialUI_Timer.SetActive(true);
                nrNext++;
            break;
            case 4:
                TutorialUI_Timer.SetActive(false);
                TutorialUI.SetActive(false);
                 Tutorial.SetActive(false);
                GameUI.SetActive(true);
                Mondo.SetActive(true);
                nrNext++;
                Camera1.SetActive(true);
                CameraUI.SetActive(false);
                Messenger.Broadcast(GameEvent.START_GAME, MessengerMode.DONT_REQUIRE_LISTENER);
            break;
            default:
                TututorialKeys.SetActive(false);
                TutorialUI_Menu.SetActive(false);
                TutorialUI_Energy.SetActive(false);
                TutorialUI_Life.SetActive(false);
                TutorialUI_Timer.SetActive(false);
                TutorialUI.SetActive(false);
                Tutorial.SetActive(false);
                GameUI.SetActive(true);
                Mondo.SetActive(true);
                CameraUI.SetActive(false);
                Camera1.SetActive(true);
                Messenger.Broadcast(GameEvent.START_GAME, MessengerMode.DONT_REQUIRE_LISTENER);

            break;
        }
  
    }
}
