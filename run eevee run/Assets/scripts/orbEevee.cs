﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class orbEevee : MonoBehaviour {
    
    public static int orbs;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player"){
            if (orbs < 3) {
                orbs += 1;
                Destroy(gameObject);
            }else{
                Destroy(gameObject);
            }
        }
        
    }
}
