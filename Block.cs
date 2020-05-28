using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    public Player player;
   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player = other.GetComponent<Player>();
        
         

            if (player != null && CoinKeeper.Powerups <=  0 && player.invulnerable == false)
            {
                player.knockbackCount = 0.2f;         
              
                    player.knockFromRight = true;
                
       
            }



            if (player != null && player.powerUp > 0)
            {
                Destroy(this.gameObject);
  
            }
        }
    }
}
