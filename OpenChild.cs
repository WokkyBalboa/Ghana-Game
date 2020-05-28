using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenChild : MonoBehaviour
{

	public GameObject Child;
	public GameObject heyChild;

	public void Load()
		{
		heyChild.SetActive(false);
		Child.SetActive(true);
		}
}
