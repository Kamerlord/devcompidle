using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

    public Text cashText;

    public float cash = 0;
    public float cashPerClick = 1;

    //Upgrades

    //Summoner Novice

    public float summonerNovicePrice = 100;
    public float summonerNoviceLevel = 1;
    public bool summonerNoviceBought = false;
    public float summonerNoviceIncome = 1;
    public float summonerNoviceSpeed = 1;

	void Start () {


	}
	
	void Update () {
        cashText.text = cash.ToString();
	}

}
