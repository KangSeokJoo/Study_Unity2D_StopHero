﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour {

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("GM").GetComponent<GM>().minigameStart();
        Destroy(gameObject);
    }
    
    
}
