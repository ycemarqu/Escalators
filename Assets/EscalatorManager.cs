using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscalatorManager : MonoBehaviour
{
    // Debug Purposes
    [Range(0f,1f)]
    public float animationPercentage = 0f;
    
    public bool isActive = false;
    private Animator _anim;
    private string ESCALATOR_ANIMATION_NAME = "EscalatorExpand";
    
    
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
}
