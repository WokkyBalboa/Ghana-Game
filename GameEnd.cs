using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{

    public Image spriterenderer;
    public Sprite Happy;
    public GameObject gameEnd;


    // Update is called once per frame
    void Update()
    {
   
        if (CoinKeeper.Building1 == true && CoinKeeper.Building2 == true)
        {
            this.spriterenderer.sprite = Happy;
            if(CoinKeeper.GameFinished == 2)
            {
                gameEnd.SetActive(true);
                CoinKeeper.GameFinished--;
            }
        }
    }
}
