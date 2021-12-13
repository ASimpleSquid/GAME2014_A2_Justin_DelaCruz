///////////////////////////////
/// SoundManager.cs
/// Justin Dela Cruz
/// 101127646
/// Last Modified: 2021-12-12
/// This .cs file plays audio sound effects for the game
/// GAME2014 - Assignment 2
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip playerJump, playerBounce;
    static AudioSource audioSrc;

    void Start()
    {
        playerJump = Resources.Load<AudioClip>("Jump");
        playerBounce = Resources.Load<AudioClip>("Bounce");

        audioSrc = GetComponent<AudioSource>();

    }

    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            // Allows sounds to play during specific calls, Plays sound once

            case "Jump":
                audioSrc.PlayOneShot(playerJump);
                break;
            case "Bounce":
                audioSrc.PlayOneShot(playerBounce);
                break;
        }
    }
}
