using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class StartPage : MonoBehaviour
{
    [SerializeField] private GameObject StartPanel;
    [SerializeField] private GameObject InfoPanel;
    [SerializeField] private InputField Username;

    public void StartGame()
    {
        gameObject.SetActive(false);
        setUsername();
        Messenger.Broadcast(GameEvent.START_TUTORIAL, MessengerMode.DONT_REQUIRE_LISTENER);
    }


    public void InfoGame()
    {
        StartPanel.SetActive(false);
        InfoPanel.SetActive(true);
    }

    public void backToMainStart()
    {
        InfoPanel.SetActive(false);
        StartPanel.SetActive(true);
    }

    public void setUsername()
    {
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