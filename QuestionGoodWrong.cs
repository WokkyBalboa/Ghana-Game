using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuestionGoodWrong : MonoBehaviour
{

    public bool GoodWrong;
    public string good = "Correct! \n";
    public string wrong = "Wrong! \n";
    public Text quizA;

    public void Awake()
    {
        quizA = GameObject.Find("QuizAText").GetComponent<Text>();
        quizA = GetComponent<Text>();
    }

    public void Load()
    {
        if(GoodWrong)
        {
            quizA.text = good;
        }

        else
        {
            quizA.text = wrong;
        }
    }
}
