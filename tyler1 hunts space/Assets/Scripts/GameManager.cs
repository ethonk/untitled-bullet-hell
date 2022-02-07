using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BulletHell.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] VoidEvent keypress_space;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            keypress_space.Raise();
        }
    }
}
