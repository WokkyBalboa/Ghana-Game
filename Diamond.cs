﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour {

    public int gems = 1;
    public AudioClip CoinCol;
 

    //behavoir of the diamonds, destroy themself if collided with player and add 1 diamond to player
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag =="Player")
        {
            Player player = other.GetComponent<Player>();

            if (player != null)
            {
                player.coins += gems;
                player.source.PlayOneShot(CoinCol);
                Destroy(this.gameObject);
            }
        }
    }
}
