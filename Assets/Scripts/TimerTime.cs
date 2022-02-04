using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerTime : MonoBehaviour
{
    [SerializeField] private Text timerText;

    private int _timeH;
    private int _timeM;
    private string _timeS;
    private float _timeReal;
    public bool _decrase;

    //public static TimerTime Instance = null;


    void Awake()
    {
        _timeH = 48;
        _timeM = 0;
        _timeReal = 0;
        _decrase = false;
        //Instance = this;
    }

    void resetValues()
    {
        _timeH = 48;
        _timeM = 0;
        _timeReal = 0;
        _decrase = true;
        _timeS = _timeH.ToString("D2") + ":" + _timeM.ToString("D2") + "H";
        timerText.text = _timeS;
    }

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = _timeS;
        Messenger.AddListener(GameEvent.GAME_OVER, StopDecrase);
        Messenger.AddListener(GameEvent.RESET_GAME, resetValues);
        Messenger.AddListener(GameEvent.START_GAME, resetValues);
    }


    public void StopDecrase()
    {
        _decrase = false;
    }

    public void Update()
    {
        if (_decrase)
        {
            //variabile tempo reale aumento con il delta time
            _timeReal += Time.deltaTime;
            if (_timeReal >= 1)
            {
                if (_timeM == 0)
                {
                    _timeH = _timeH - 1;
                    _timeM = 59;
                }
                else
                {
                    _timeM = _timeM - 1;
                }

                if (_timeM <= 0 && _timeH <= 0)
                {
                    _decrase = false;
                    Messenger.Broadcast(GameEvent.GAME_OVER, MessengerMode.DONT_REQUIRE_LISTENER);
                    //PauseControl.Instance.PauseGame(true);
                }

                _timeS = _timeH.ToString("D2") + ":" + _timeM.ToString("D2") + "H";
                timerText.text = _timeS;
                _timeReal = 0;
            }
        }
    }
}