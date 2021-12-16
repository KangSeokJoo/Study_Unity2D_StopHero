using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyMonster : MonoBehaviour {

    public GameObject boom, swamp, Menutext, counttext;
    GameObject ui;

    // Use this for initialization
    void Start()
    {
        ui = GameObject.Find("UI");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BoomBT()
    {
        if (ui.GetComponent<InterfaceUI>().max > 0)
        {
            ui.GetComponent<InterfaceUI>().maxMinus();
            Instantiate(boom, transform.position, transform.rotation);
        }
        else
        {
            return;
        }

        Menutext.SetActive(false);
        counttext.SetActive(true);
    }

    public void SawpBT()
    {
        if (ui.GetComponent<InterfaceUI>().max > 0)
        {
            ui.GetComponent<InterfaceUI>().maxMinus();
            Instantiate(swamp, transform.position, transform.rotation);
        }
        else
        {
            return;
        }

        Menutext.SetActive(false);
        counttext.SetActive(true);
    }
}
