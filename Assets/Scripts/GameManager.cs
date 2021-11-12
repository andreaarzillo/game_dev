using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    // make sure the constructor is private, so it can only be instantiated here
    private GameManager()
    {
        InputInteraction = false;
    }

    public bool InputInteraction { get; set; }

    public static GameManager Instance { get; } = new GameManager();

}