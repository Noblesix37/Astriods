using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject player;
    public GameObject asteroidPrefab;
    public static GameManager instance;
    public int lives = 3;
    public int score = 0;
    public bool isPaused = false;
    public List<GameObject> enemieslist = new List<GameObject>();
    public GameObject[] enemyprefabs;

     void Start()
   
    {
 
    }
    public void Update()
    {
         if (Input.GetKey(KeyCode.Escape))
        {
             Application.Quit();
        }

    }
    public void Respawn()
    {
        Instantiate(playerPrefab);
    }
    public void Awake()
    {
        if (instance == null)
        { instance = this; }
        else
        {
         Destroy(this.gameObject);
            Debug.LogError(message: "i tried to create a second game manager");
        }
        
    }
}