using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Rigidbody2D rb;
    public Player player;
    public SpriteRenderer spriteRender;
    public GameObject PoweredUp;
    public GameObject smallEnemy;
    public GameObject PlayerChar;
   
    public bool isBig;

    void Start()
    {
        PoweredUp = GameObject.Find("PoweredUp");
    }
    void FixedUpdate()
    {
        PoweredUp = GameObject.Find("PoweredUp");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player = other.GetComponent<Player>();
            rb = other.gameObject.GetComponent<Rigidbody2D>();
            spriteRender = other.GetComponent<SpriteRenderer>();

            if (player != null && player.powerUp <= 0 && player.invulnerable == false)
            {
                player.knockbackCount = 0.2f;
                player.lives--;
                
                if(other.transform.position.x < transform.position.x)
                {
                    player.knockFromRight = true;
                }
                else
                {
                    player.knockFromRight = false;
                }

                player.invulnerable = true;
                spriteRender.sprite = player.hurtSprite;
                Invoke("resetInvulnerability", 3);
                Invoke("restoreCharacter", 3);
            }

            if (player != null && player.powerUp > 0 && isBig == true)
            {

                player.knockbackCount = 0.2f;
                if (other.transform.position.x < transform.position.x)
                {
                    player.knockFromRight = true;
                }
                else
                {
                    player.knockFromRight = false;
                }

                
                Instantiate(smallEnemy,new Vector2(transform.position.x, transform.position.y),Quaternion.identity);
                Destroy(this.gameObject);
                CoinKeeper.Powerups--;
                if (CoinKeeper.Powerups == 0)
                {
                    PoweredUp.SetActive(false);
                }
            }

            if (player != null && player.powerUp > 0 && isBig == false)
            {
                Destroy(this.gameObject);
                player.EnemiesKilled++;
                CoinKeeper.Powerups--;
                if (CoinKeeper.Powerups == 0)
                {
                    PoweredUp.SetActive(false);
                }
            }
        }
    }

            void resetInvulnerability()
            {
                player.invulnerable = false;
            }

            void restoreCharacter()
    {
        spriteRender.sprite = player.normSprite;
    }
}
