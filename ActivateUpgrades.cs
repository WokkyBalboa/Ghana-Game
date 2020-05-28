using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateUpgrades : MonoBehaviour
{

    public GameObject Upgrade1;
    public GameObject Upgrade2;
    public GameObject Lvl2;



    // Update is called once per frame
    void Update()
    {
        if(CoinKeeper.Building1)
        {
            Upgrade1.SetActive(true);
            Lvl2.SetActive(true);
        }
        if(CoinKeeper.Building2)
        {
            Upgrade2.SetActive(true);
        }
    }
}
