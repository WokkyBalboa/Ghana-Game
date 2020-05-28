using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BGMover : MonoBehaviour
{
    [SerializeField] List<GameObject> segments;

    // Use this for initialization
    void Start()
    {
        GameObject prev = null;
        foreach (var bg in segments)
        {
            if (prev !=
            null)
            {
                Bounds box = bg.GetComponent<Renderer>().bounds;
                bg.transform.position = new Vector3(prev.GetComponent<Renderer>().bounds.max.x + box.extents.x, bg.transform.position.y, 0);
            }
            prev = bg;
        }

    }



    // Update is called once per frame
    void Update()
    {
        foreach (var bg in segments)
        {
            bg.transform.Translate(Vector3.left * 20 * Time.deltaTime);

        }

        var segment = segments[0];
        Bounds segmentBounds = segment.GetComponent<Renderer>().bounds;
        // magic number alert: position out of sight on the left
        if (segmentBounds.max.x < -80)
        {
            // pop the segment from the array
            segments.Remove(segment);
            segment.transform.position = new Vector3(segments[segments.Count - 1].GetComponent<Renderer>().bounds.max.x + segmentBounds.extents.x, segment.transform.position.y, 0);

            // push the segment back on the array at the end
            segments.Add(segment);

        }

    }

}