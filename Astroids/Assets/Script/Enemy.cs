using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int movespeed = 1;
    public Transform player;
   
    
   

     void Start()
    {
        GameManager.instance.enemieslist.Add(this.gameObject);
        
    }
    public void Update()
    {
       
    }
    public void OnCollisionEnter2D(Collision2D OtherObject)
    {
        Destroy(OtherObject.gameObject);
        Destroy(this.gameObject);
    }

    void OnDestroy()
    {
        GameManager.instance.enemieslist.Remove(this.gameObject);
    }
}

