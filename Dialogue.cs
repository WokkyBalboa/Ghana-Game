using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Text text;
    public TextAsset textFile;
    public GameObject deactivate;
    public GameObject activated;
    public string textName;
    public int i;
    public bool check = true;
    public bool setactive;
    public bool setdeactive;
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

    void LateUpdate()
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
            if (setdeactive)
            {
                deactivate.SetActive(false);
            }
            if(setactive)
                {
                activated.SetActive(true);
            }
            i = 0;
        }
    }
    public void touchCheck()
    {
        if (checkInputTouch() == false)
        {
            touch = false;
        }
    }
    
    public void load()
    {

        if (touch = false && checkInputTouch() == true || Input.GetMouseButtonDown(0))
        {
            i++;
            touch = true;
        }
        
    }
}
