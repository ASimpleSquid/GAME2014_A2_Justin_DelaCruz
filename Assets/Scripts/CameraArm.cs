///////////////////////////////
/// CameraArm.cs
/// Justin Dela Cruz
/// 101127646
/// Last Modified: 2021-12-12
/// This .cs file helps the camera follow the player
/// GAME2014 - Assignment 2
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraArm : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
    }
}
