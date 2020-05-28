using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForTrigger : MonoBehaviour
{
	public GameObject Dialogue;
	public GameObject Rabbit;

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			Dialogue.SetActive(true);
			Rabbit.SetActive(true);
				}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if(collision.tag == "Player")
		{
			Dialogue.SetActive(false);
			Rabbit.SetActive(false);
		}
	}
}
