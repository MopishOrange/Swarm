﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ItemList : MonoBehaviour {

   
    public GameObject SpeedUpItem;
    public GameObject maxHealthItem;
    public GameObject bonusPointsItem;
    public GameObject shieldItem;
    public List<GameObject> list;


	// Use this for initialization
	void Start () {
        list = new List<GameObject>();
        list.Add(SpeedUpItem);
        list.Add(maxHealthItem);
        list.Add(bonusPointsItem);
        list.Add(shieldItem);
        Debug.Log("items: " + list.Count);
        // more!
	}

    public GameObject chooseRandoItem() {
        
        int rando = Random.Range(0, list.Count);
        return list[rando];
    }

}


// idea: implement tiered objects of different raritites in different lists
        // later