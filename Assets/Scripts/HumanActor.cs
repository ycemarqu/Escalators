using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HumanActor : MonoBehaviour
{
    private Transform firstTarget;
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();
        
        var firstEscalator = GameplayManager.Instance.EscalatorsInOrder[0];
        if (firstEscalator == null)
        {
            Debug.LogError("Couldn't find First Escalator ");
        }
        firstTarget = firstEscalator.GetComponent<EscalatorActor>().GetTargetObject().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (firstTarget == null) return;
            transform.DOMove(firstTarget.position,1f);
    }
}
