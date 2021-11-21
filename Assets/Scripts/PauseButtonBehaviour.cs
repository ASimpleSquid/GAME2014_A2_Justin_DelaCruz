///////////////////////////////
/// PauseButtonBehaviour.cs
/// Justin Dela Cruz
/// 101127646
/// Last Modified: 2021-10-03
/// This .cs file makes the button
/// go to the Game Over Scene
/// GAME2014 - Assignment 1
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButtonBehaviour : MonoBehaviour
{
    // This Button Temporarly ends the gameplay for now
    public void OnPauseButtonPressed()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
