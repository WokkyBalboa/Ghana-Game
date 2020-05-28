using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizExplenation : MonoBehaviour
{
 
    public Text text;
    public TextAsset textFile;

    void Start()
    {
        text = GetComponent<Text>();
        Displaytext();
    }


    public void Displaytext()
    {
        
            text.text = text.text + textFile;
  
    }



    
}
