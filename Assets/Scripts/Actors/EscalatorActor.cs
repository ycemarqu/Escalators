using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscalatorActor : MonoBehaviour
{
    public static event Action DeactivateEscalator;
    
    // Debug Purposes
    [Range(0f,1f)]
    public float animationPercentage = 0f;
    
    public bool isActive = false;
    private Animator _anim;
    private string ESCALATOR_ANIMATION_NAME = "EscalatorExpand";
    private int _insideHumanCount = 0;
    private int _sentHumanCount = 0;
    
    private static readonly int DoorOpen = Animator.StringToHash("DoorOpen");

    // private string TARGET_TAG = "EscalatorFollowTarget";
    
    
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Activate Escalator if everyone is inside
        if (!isActive && _insideHumanCount == GameplayManager.Instance._humanCount) isActive = true;
        
        if (isActive)
        {
            // if (_insideHumanCount == GameplayManager.Instance._humanCount)
            // {
            //     animationPercentage += 0.1f;
            //     _anim.Play(ESCALATOR_ANIMATION_NAME, 0, animationPercentage);
            // }


            if (Input.GetKey(KeyCode.Space))
            {
                _anim.SetBool(DoorOpen, true);
            }
            
            else 
            {
                _anim.SetBool(DoorOpen, false);
            }
            
            // Deactivate Escalator
            if (_insideHumanCount == 0) Deactivate();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Human"))
        {
            _insideHumanCount++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Human"))
        {
            _insideHumanCount--;
            _sentHumanCount++;
        }
    }

    public void Deactivate()
    {
        isActive = false;
        DeactivateEscalator?.Invoke();
    }


    // public Transform GetTargetObject()
    // {
    //     for (int i = 0; i < transform.childCount; i++)
    //     {
    //         Transform child = transform.GetChild(i);
    //         if (child.tag == TARGET_TAG)
    //         {
    //             return child;
    //         }
    //     }
    //
    //     return null;
    // }
}
