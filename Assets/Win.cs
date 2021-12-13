///////////////////////////////
/// Win.cs
/// Justin Dela Cruz
/// 101127646
/// Last Modified: 2021-12-12
/// This .cs file helps Detect if
/// the player has reached the end
/// GAME2014 - Assignment 2
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] GameObject winMenu;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            winMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
