using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class UpgradeButton : MonoBehaviour {

    public GameManager GM;
    public Button SummonerNoviceShopButton;
    public GameObject SummonerNovice;

    private void Start()
    {
        SummonerNoviceShopButton.onClick.AddListener(SummonerNoviceShopBuy);
    }

    private void Update()
    {
        if (GM.cash >= 100 && GM.summonerNoviceBought == false)
        {
            SummonerNoviceShopButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            SummonerNoviceShopButton.GetComponent<Button>().interactable = false;
        }
    }

    private void SummonerNoviceShopBuy()
    {
        GM.cash -= 100;
        GM.summonerNoviceBought = true;
        SummonerNoviceShopButton.GetComponent<Button>().interactable = false;
        SummonerNovice.SetActive(true);
    }


}
