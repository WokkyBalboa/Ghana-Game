using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour {

    private float groundHorizontalLength;
	// Use this for initialization
	void Start () {

		var rc = GetComponent<RectTransform>();
		var corners = new Vector3[4];
		rc.GetWorldCorners(corners);
		groundHorizontalLength = Mathf.Abs(corners[0].x - corners[3].x)/4f;
		Debug.Log("groundHorizontalLength = " + groundHorizontalLength);

	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < -groundHorizontalLength)
        {
            RepositionBackground();
        }

	}

    private void RepositionBackground()
    {
        Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2f, 0);

        transform.position = (Vector2)transform.position + groundOffSet;
    }
}
