using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SettingsPopup : MonoBehaviour
{
    [SerializeField]
    private GameObject gameFilter;
    
    
    public void Open()
    {
        gameObject.SetActive(true); //object on top of the window ??
        PauseControl.Instance.PauseGame(true);
        GameManager.Instance.InputInteraction = false;
        gameFilter.SetActive(false);
    }

    public void Close()
    {   
        gameObject.SetActive(false); //turn it off ??
        PauseControl.Instance.PauseGame(false);
        GameManager.Instance.InputInteraction = true;
        gameFilter.SetActive(true);


    }

    public void Submit()
    {
        //OnSubmitName(playerName.text);
        Close();
    }


}