using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelStars : MonoBehaviour
{

    public Player player;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;
    private Text UItext;
    public int MaxStar;
    public int MidStar;
    public int LowStar;
    // Start is called before the first frame update
    void Start()
    {
        UItext = GetComponent<Text>();
        UItext.text = "" + player.coins;
        starCheck();
    }

   void starCheck()
    {
        if(player.coins >= LowStar)
        {
            Star1.SetActive(true);
        }
        if (player.coins >= MidStar)
        {
            Star2.SetActive(true);
        }
        if (player.coins >= MaxStar && player.EnemiesKilled == player.EnemiesAmount)
        {
            Star3.SetActive(true);
        }
    }
}
