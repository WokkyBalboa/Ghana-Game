using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

    public float scrollSpeed = -1.5f;
	public new GameObject camera;
	public float relativeCameraSpeed = 1f;

	private Vector3 prevCameraPos;

	// Use this for initialization
	void Start()
	{
		if (camera != null)
		{
			prevCameraPos = camera.transform.position;
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (camera == null)
		{
			transform.position += new Vector3(scrollSpeed*Time.deltaTime, 0, 0);
		}
		else
		{
			var delta = camera.transform.position - prevCameraPos;
			delta.y = delta.z = 0;

			transform.position += delta * relativeCameraSpeed;

			prevCameraPos = camera.transform.position;
		}
    }
}
