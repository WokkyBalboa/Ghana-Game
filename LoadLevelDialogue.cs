using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadLevelDialogue : MonoBehaviour
{
   
    public Text text;
    public TextAsset textFile;
    public string textName;
    public string loadLvl;
    public int i;
    public bool check = true;
    private bool touch = false;
    string[] TextLine;

    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find(textName).GetComponent<Text>();
        if (textFile != null)
        {
            TextLine = (textFile.text.Split('\n'));
        }

    }

    void Update()
    {

        deact();
        text.text = TextLine[i];
        load();

    }

    bool checkInputTouch()
    {
        return (Input.touchCount > 0);
    }

    public void deact()
    {
        if (i == TextLine.Length)
        {
            i = 0;
            SceneManager.LoadScene(loadLvl);
        }
    }

    public void touchCheck()
    {
        if (checkInputTouch() == false)
        {
            touch = false;
        }
    }
    // Update is called once per frame
    public void load()
    {

        if (touch == false && checkInputTouch() == true || Input.GetMouseButtonDown(0))
        {
            i++;
            touch = true;
        }

    }
}
