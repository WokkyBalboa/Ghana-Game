using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour {
    private Vector3 startPos;
    private Vector3 endPos;
    public float deltaMove = 3;
    public float speed = 2.0f;
    private bool moveUp;
    public float delay = 2;
    // Use this for initialization
    void Start () {
        startPos = transform.position;
        endPos = new Vector3(transform.position.x, transform.position.y + deltaMove, transform.position.z);
        moveUp = true;
        StartCoroutine(movePlatform());
	}
	

    // Move the platform from target to target, if it reaches a target it'll wait 2 sec before moving again.
    IEnumerator movePlatform()
    {
		while (true)
		{
			float step = speed * Time.deltaTime;

			if (moveUp)
			{
				transform.position = Vector3.MoveTowards(transform.position, startPos, step);
			}
			else
			{
				transform.position = Vector3.MoveTowards(transform.position, endPos, step);
			}

			if (transform.position == startPos)
			{
				moveUp = false;
			}
			else if (transform.position == endPos)
			{
				moveUp = true;
			}
			else
			{
				yield return null;
				continue;
			}

			yield return new WaitForSeconds(delay);
		}
	}
}
