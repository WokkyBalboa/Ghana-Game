using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour {

    private Text levelIntro;
    private int intro = 0;
    public string Level;


    public void Load()
    {

        SceneManager.LoadScene(Level);
    }
}
