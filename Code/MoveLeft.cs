﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
   public float speed;
    private PlayerController PCS;

    // Start is called before the first frame update
    void Start()
    {
       // Finds and Stores controller script for later access
        PCS = GameObject.Find("Player").GetComponent<PlayerController>();
        Destroy(gameObject, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(PCS.isGameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        
    }
}
