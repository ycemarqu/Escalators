using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public enum SlidingDirection
{
    Left,Right
}

public class SliderActor : MonoBehaviour
{
    public SlidingDirection slidingDirection;
    public float moveAmount;
    
    private void Awake()
    {
        if (slidingDirection == SlidingDirection.Right)
            moveAmount *= -1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,0,moveAmount * Time.deltaTime);
    }
}
