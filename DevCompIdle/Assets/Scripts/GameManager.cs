﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text cashText;

    public float cash = 0;
    public float cashPerClick = 1;
    public float cashPerSecond = 1;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cashText.text = "Cash: " + cash;
	}
}
