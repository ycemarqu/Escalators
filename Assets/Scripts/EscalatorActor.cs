using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscalatorActor : MonoBehaviour
{
    // Debug Purposes
    [Range(0f,1f)]
    public float animationPercentage = 0f;
    
    public bool isActive = false;
    private Animator _anim;
    private string ESCALATOR_ANIMATION_NAME = "EscalatorExpand";

    private string TARGET_TAG = "EscalatorFollowTarget";
    
    
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            _anim.Play(ESCALATOR_ANIMATION_NAME, 0, animationPercentage);
        }
    }
    
 
    public Transform GetTargetObject()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            if (child.tag == TARGET_TAG)
            {
                return child;
            }
        }

        return null;
    }
}
