using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    private int maxPower = 4;
    public GameObject PoweredUp;
    public PoweredUpUI powerUp;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if (CoinKeeper.Powerups == 0)
            {
                PoweredUp.SetActive(true);
            }
            if (player != null)
            {
                if (player.powerUp < maxPower)
                {
                    CoinKeeper.Powerups++;
                }
                Destroy(this.gameObject);
            }

        }
    }
}
