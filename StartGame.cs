using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    public string loadLvl;
    public GameObject introtext;
    public Player player;
    public bool playerTrue;


    public void Load()
    {

        DontDestroyOnLoad(introtext);
        introtext.SetActive(true);
        if (playerTrue)
        {
            CoinKeeper.coinKeeper += player.coins;
        }
        SceneManager.LoadScene(loadLvl);
    }
}
