using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayScript : MonoBehaviour
{

    public void Close()
    {
        gameObject.SetActive(false); //turn it off ??
        PauseControl.Instance.PauseGame(false);
        GameManager.Instance.InputInteraction = true;
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
