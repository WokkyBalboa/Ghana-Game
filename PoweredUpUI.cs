using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweredUpUI : MonoBehaviour
{
    public Player player;
    public SpriteRenderer spriteRender;
    public bool powerUp = false;
    public Sprite Shield1;
    public Sprite Shield2;
    public Sprite Shield3;
    public Sprite Shield4;


    private void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {
        follow();
        spriteChange();
    }

    void follow()
    {
        this.transform.position = player.transform.position;
    }

    void spriteChange()
    {
       
            if (player.powerUp == 1)
            {
                spriteRender.sprite = Shield1;
            }
            if(player.powerUp == 2)
                    {
                spriteRender.sprite = Shield2;
            }
            if (player.powerUp == 3)
            {
                spriteRender.sprite = Shield3;
            }
            if (player.powerUp == 4)
            {
                spriteRender.sprite = Shield4;
            }
         
    }


}
