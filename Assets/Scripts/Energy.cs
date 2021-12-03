using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{
    [SerializeField]
    private Slider energyValue;

    private float _energy;
    private float _timeReal;
    public bool _energyDecrase;
    private float _totalTime;
    public bool _decrase;

    // Start is called before the first frame update

    void Awake()
    {
         _energy = 0.0f;
        _timeReal = 0;
        _decrase = false;

    }


     void resetValues(){
        _energy = 1.0f;
        _timeReal = 0;
        _decrase = true;

    }

    void Start()
    {

        energyValue.value = _energy;
        Messenger.AddListener(GameEvent.GAME_OVER, StopDecrase);
        Messenger.AddListener(GameEvent.RESET_GAME, resetValues);
        Messenger.AddListener(GameEvent.START_GAME, resetValues);



        
    }


    void StopDecrase(){
        _decrase = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(_decrase){
            _totalTime+=Time.deltaTime;
            _timeReal+= Time.deltaTime;
            if(_timeReal>=0.03f){ 
                //energyValue.value = _energy;
                _energy -= (_timeReal/100f);
                if(_energy<=0){
                    _energy = 0;
                    _energyDecrase = false;
                }
                energyValue.value = _energy;
                _timeReal = 0;
            }
        }
        
    }
}
