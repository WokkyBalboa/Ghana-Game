using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenBlock : MonoBehaviour
{

    public float speed = 0.1f;
    public float min = .5f;
    public float max = 1.0f;
    public SpriteRenderer render;
    public Color color;
    private bool trigger = false;

    private void Start()
    {
        color = render.material.color;
    }

    private void LateUpdate()
    {
        if (trigger)
        {
            OpacityDown();
        }
        if (trigger == false)
        {
            OpacityUp();
        }
    }

    private void OpacityDown()
    {
        if (color.a >= min)
            {
                color.a -= speed;
                render.material.color = color;
            }
    }

    private void OpacityUp()
    {
        if (color.a <= max)
            {
                color.a += speed;
                render.material.color = color;
            }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            trigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            trigger = false;
        }
    }
}
