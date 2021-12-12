///////////////////////////////
/// GuideButtonBehaviour.cs
/// Justin Dela Cruz
/// 101127646
/// Last Modified: 2021-12-12
/// This .cs file makes a button go
/// to the instructions screen
/// GAME2014 - Assignment 2
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuideButtonBehaviour : MonoBehaviour
{
    public void OnGuideButtonPressed()
    {
        SoundManager.PlaySound("Button");
        SceneManager.LoadScene("InstructionsScene");
    }
}
