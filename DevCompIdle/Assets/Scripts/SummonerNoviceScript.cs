using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonerNoviceScript : MonoBehaviour {

    public GameManager GM;


    void Start () {
        StartCoroutine(SummonerNoviceTimer());
	}

    private IEnumerator SummonerNoviceTimer()
    {
        while (GM.summonerNoviceBought == true)
        {
            GM.cash += GM.summonerNoviceIncome;
            yield return new WaitForSeconds(GM.summonerNoviceSpeed);
        }
    }
}
