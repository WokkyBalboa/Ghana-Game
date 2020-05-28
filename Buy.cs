using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buy : MonoBehaviour
{

    public int Cost;
    public int ActivateID;
 

    // Update is called once per frame
    public void load()
    {
        if(CoinKeeper.coinKeeper >= Cost)
        {
            CoinKeeper.coinKeeper = CoinKeeper.coinKeeper - Cost;
            if (ActivateID == 1)
            {
                CoinKeeper.Building1 = true;
                CoinKeeper.GameFinished++;
                this.gameObject.SetActive(false);
            }
            if(ActivateID == 2)
            {
                CoinKeeper.Building2 = true;
                CoinKeeper.GameFinished++;
                this.gameObject.SetActive(false);
            }

            

            if(ActivateID == 4)
            {
                CoinKeeper.Powerups++;
            }

        }

    }
}
