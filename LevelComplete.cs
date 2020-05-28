using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

    public string loadLvl;
    public Player player;

    public void Load()
    {
        CoinKeeper.coinKeeper += player.coins;
        SceneManager.LoadScene(loadLvl);
        
    }
}
