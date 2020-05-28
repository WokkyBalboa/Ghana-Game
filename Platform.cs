using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    public Transform startTarg;
    public Transform endTarg;
    public float speed = 2.0f;
    private bool moveUp;
    public int delay = 3;
    
 

    // Use this for initialization
    void Start () {
        moveUp = true;
        StartCoroutine(movePlatform());

	}
    // Update is called once per frame
    void LateUpdate()
    {
       
    }

    // Move the platform from target to target, if it reaches a target it'll wait 2 sec before moving again.
    IEnumerator movePlatform ()
    {
		while (true)
		{
			float step = speed * Time.deltaTime;

			if (moveUp)
			{
				transform.position = Vector3.MoveTowards(transform.position, startTarg.position, step);
			}
			else
			{
				transform.position = Vector3.MoveTowards(transform.position, endTarg.position, step);
			}

			if (transform.position == startTarg.position)
			{
				moveUp = false;
			}
			else if (transform.position == endTarg.position)
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.transform.parent = transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.transform.parent = null;
        }
    }



}
