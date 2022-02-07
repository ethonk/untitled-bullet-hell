using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BulletHell.Events;

public class SoundManager : MonoBehaviour
{
    [Header("Core")]
    public AudioSource audioSource;

    [Header("Sounds")]
    public AudioClip gameStartSound;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void StartGame()
    {
        audioSource.PlayOneShot(gameStartSound);
    }
}
