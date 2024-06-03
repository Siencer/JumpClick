using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RepeatBackground : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 startingPosition;
    //private float exactLocation = -11.5f;
    private float repeatWidth;
    void Start()
    {
        startingPosition = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startingPosition.x - repeatWidth)
        {
            transform.position = startingPosition;
        }
    }
}
