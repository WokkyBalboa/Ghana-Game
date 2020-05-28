using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectDeactivate : MonoBehaviour
{
    public GameObject Deactivate;


    public void load()
    {
        Deactivate.SetActive(false);
    }
  
}
