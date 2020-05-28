using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    public GameObject healthbar;
    public Player player;
    public float health;
    public float healthOld = 1f;
    public float multiply = .25f;
    // Start is called before the first frame update
    void Start()
    {
        healthbar = GameObject.Find("HealthBar");
    }

    // Update is called once per frame
    void Update()
    {
        health = player.lives * multiply;
        SetSize();
    }

    void SetSize()
    {
        if (health < healthOld)
        {
            healthOld -= .01f;
            healthbar.transform.localScale = new Vector3(healthOld, 1f);
        }
    }
}
