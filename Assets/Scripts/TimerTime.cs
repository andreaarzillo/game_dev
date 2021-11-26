using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerTime : MonoBehaviour
{
    [SerializeField]
    private Text timerText;
    private int _timeH;
    private int _timeM;
    private string _timeS; 
    private float _timeReal;
     private bool _running;

    //public static TimerTime Instance = null;


    void Awake()
    {
        _timeH = 48;
        _timeM = 0;
        _timeReal = 0;
        _timeS = _timeH.ToString("D2")+":"+_timeM.ToString("D2")+"H";
        //Instance = this;
        

    }

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = _timeS;
        _running = true;
   
    }

    public void Update(){
        //variabile tempo reale aumento con il delta time
            _timeReal+= Time.deltaTime;
            if(_timeReal>=1 && _running){
                if (_timeM == 0){
                _timeH = _timeH-1;
                _timeM = 59;
                }else{
                    _timeM = _timeM-1;
                }
                if(_timeM <= 0 && _timeH <= 0){
                    _running = false;
                 
                    Messenger.Broadcast(GameEvent.GAME_OVER, MessengerMode.DONT_REQUIRE_LISTENER);
                    //PauseControl.Instance.PauseGame(true);
                }
                _timeS = _timeH.ToString("D2")+":"+_timeM.ToString("D2")+"H";
                timerText.text = _timeS;
                _timeReal = 0;
            }
            
        
    }


}
