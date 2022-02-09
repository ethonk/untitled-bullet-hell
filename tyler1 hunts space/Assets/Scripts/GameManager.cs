using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BulletHell.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] VoidEvent gameStartEvent;
    [SerializeField] Camera mainCamera;
    bool gameStarted;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !gameStarted)
        {
            gameStarted = true;
            gameStartEvent.Raise();
        }
    }
}
