using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickWall : MonoBehaviour
{

    public Player player;
    private int reverse = 5;
    private int reversejump = -1;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            player = other.transform.GetComponent<Player>();
            player.gravity = player.gravity + reverse;
            player.jumpForce = player.jumpForce * reversejump;
            player.grounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            player = other.transform.GetComponent<Player>();
            player.gravity = player.gravity - reverse;
            player.jumpForce = player.jumpForce * reversejump;
        }
    }
}
