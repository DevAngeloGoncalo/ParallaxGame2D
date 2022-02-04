using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float moveSpeed = 1F, offset;

    private Vector2 startPos;
    private float newXPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        newXPos = Mathf.Repeat(Time.time * - moveSpeed, offset);
        transform.position = startPos + Vector2.right * newXPos;
    }
}
