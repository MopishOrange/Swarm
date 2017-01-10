﻿using UnityEngine;
using System.Collections;

public class OneUpItem : MonoBehaviour {

    GameObject Player;
    void Start()
    {
        Player = GameObject.Find("Player");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Attributes stats = other.GetComponent<Attributes>(); 
            stats.heal();
           
        }

    }
}
