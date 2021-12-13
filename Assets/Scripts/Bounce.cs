///////////////////////////////
/// Bounce.cs
/// Justin Dela Cruz
/// 101127646
/// Last Modified: 2021-12-12
/// This .cs file helps the Jump Platforms 
/// functon and make the player bounce
/// GAME2014 - Assignment 2
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    // This is set to public as we can modify the value for each jump pad
    public float bounce = 20f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           
            SoundManager.PlaySound("Bounce");
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
        }
    }
}
