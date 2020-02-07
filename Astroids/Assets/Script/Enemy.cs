using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int movespeed = 1;
    public Vector3 userDirection = Vector3.right;
   

    public void Update()
    {
        transform.Translate(userDirection * movespeed * Time.deltaTime);
    }
    public void OnCollisionEnter2D(Collision2D OtherObject)
    {
        Destroy(OtherObject.gameObject);
    }
}

