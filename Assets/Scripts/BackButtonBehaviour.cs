///////////////////////////////
/// BackButtonBehaviour.cs
/// Justin Dela Cruz
/// 101127646
/// Last Modified: 2021-12-12
/// This .cs file makes a button go back
/// to the main menu screen
/// GAME2014 - Assignment 2
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonBehaviour : MonoBehaviour
{
    public void OnBackButtonPressed()
    {
        SoundManager.PlaySound("Button");
        SceneManager.LoadScene("MenuScene");
    }
}
