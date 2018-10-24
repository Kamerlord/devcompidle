using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHide : MonoBehaviour {

    public bool visible = false;

    public void Showhide()
    {
        if (visible == false)
        {
            this.gameObject.SetActive(true);
            visible = true;
        } else
        {
            this.gameObject.SetActive(false);
            visible = false;
        }
    }

}
