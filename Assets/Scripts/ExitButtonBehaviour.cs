///////////////////////////////
/// BackButtonBehaviour.cs
/// Justin Dela Cruz
/// 101127646
/// Last Modified: 2021-10-03
/// This .cs file makes the button end the app
/// GAME2014 - Assignment 1
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButtonBehaviour : MonoBehaviour
{
    public void OnExitButtonPressed()
    {
        Application.Quit();
        Debug.Log("Quitted");
    }
}
