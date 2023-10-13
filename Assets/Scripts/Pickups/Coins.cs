﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] int coinValue = 10;




    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // cộng 1 vào persitent data player coin trong game session
            FindObjectOfType<GameSession>().AddToScore(coinValue);

            
        }
    }

   
}
