using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public GameObject TutorialPanel;
	public GameObject Rabbit;
    public GameObject AnimationTut1;
    public GameObject AnimationTut2;
    public GameObject AnimationTut3;
    public GameObject AnimationTut4;
    public GameObject tutorialText;
    public int tutorial;
    public Player player;

    private Text TutorialText;

  
    private void Update()
    {

        ClosePanel();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {    
        if (collision.tag == "Player")
        {
            player.tutorial = tutorial;   
            TutorialPanel.SetActive(true);
			Rabbit.SetActive(true);
            pause();
            Destroy(this.gameObject);
        }
    }


    void ClosePanel()
    {
      

        if (TutorialPanel.activeSelf == true && Input.touchCount > 0||Input.GetMouseButtonDown(0))
            {
            AnimationTut1.SetActive(false);
            AnimationTut2.SetActive(false);
            AnimationTut3.SetActive(false);
            AnimationTut4.SetActive(false);
            tutorialText.SetActive(true);
            Rabbit.SetActive(false);
            TutorialPanel.SetActive(false);
            resume();
        }
    }

    void pause()
    {
            Time.timeScale = 0;
    }

    void resume()
    {
        Time.timeScale = 1;
    }

}
