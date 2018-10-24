using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UpgradeButton : MonoBehaviour {

    public GameManager GM;

    public void AddWorker1Level()
    {
        GM.worker1Level += GM.cash;
    }

}
