using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActivate : MonoBehaviour
{
    public GameObject Activate;


    public void load()
    {
        Activate.SetActive(true);
    }
}
