using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SettingsPopup : MonoBehaviour
{
    
    
    public void Open()
    {
        gameObject.SetActive(true); //object on top of the window ??
        PauseControl.Instance.PauseGame(true);
        GameManager.Instance.InputInteraction = false;
    }

    public void Close()
    {   
        gameObject.SetActive(false); //turn it off ??
        PauseControl.Instance.PauseGame(false);
        GameManager.Instance.InputInteraction = true;
    }

    public void Submit()
    {
        //OnSubmitName(playerName.text);
        Close();
    }


}