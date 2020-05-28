using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TutText : MonoBehaviour
{
    public Player player;
    private Text TutorialText;
    public GameObject AnimationTut1;
    public GameObject AnimationTut2;
    public GameObject AnimationTut3;
    public GameObject AnimationTut4;
    public int firstTutorial = 1;
    public int SecondTutorial = 2;
    public int ThirdTutorial = 3;
    public int FourthTutorial = 4;
    public int FifthTutorial = 5;
    public int SixthTutorial = 6;
    public TextAsset textFile;
    string[] TutorialLine;
    // Start is called before the first frame update //This is the CONDOM, it helps you to destroy diseases
    void Start()
    {
        TutorialText = GetComponent<Text>();
        if (textFile != null)
        {
            TutorialLine = (textFile.text.Split('\n'));
        }

    }

    // Update is called once per frame
    void Update()
    {

        
        if (player.tutorial == firstTutorial)
        {
			//this.gameObject.SetActive(false);
			TutorialText.text = TutorialLine[0];
			AnimationTut1.SetActive(true);
        }

        if (player.tutorial == SecondTutorial)
        {
			//this.gameObject.SetActive(false);
			TutorialText.text = TutorialLine[1];
			AnimationTut2.SetActive(true);
        }

        if (player.tutorial == ThirdTutorial)
        {
            TutorialText.text = TutorialLine[2];
        }

        if (player.tutorial == FourthTutorial)
        {
			//this.gameObject.SetActive(false);
			TutorialText.text = TutorialLine[3];
			AnimationTut3.SetActive(true);
        }

        if (player.tutorial == FifthTutorial)
        {
            TutorialText.text = TutorialLine[4];
        }

        if (player.tutorial == SixthTutorial)
        {
			//this.gameObject.SetActive(false);
			TutorialText.text = TutorialLine[5];
			AnimationTut4.SetActive(true);
        }
    }
}
