﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    private Button button;
  
    private GameManager gameManager;
    
    public int begin;

    // Start is called before the first frame update
    void Start()
    {
       button = GetComponent<Button>();
       
       gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
          gameManager.StartGame(begin);
    }
}
