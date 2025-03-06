using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class UiManager : MonoBehaviour
{
    
    private GameManager gameManager;
    
    [Inject]
    public UiManager(GameManager _gameManager)
    {
        gameManager = _gameManager;
    }
}
