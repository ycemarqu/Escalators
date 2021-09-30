using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;

public class HumanActor : MonoBehaviour
{
    
    
    private Transform firstTarget;

    private CharacterController _characterController;
    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _characterController.SimpleMove((transform.right) * GameplayManager.Instance.humanSpeed);
    }
}
