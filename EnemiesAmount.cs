using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesAmount : MonoBehaviour
{
    public Player player;
    private Text EnemyAText;
    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        EnemyAText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyAText.text = "" + player.EnemiesAmount;
    }
}
