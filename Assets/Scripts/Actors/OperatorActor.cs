﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorActor : MonoBehaviour
{
    
    private Operator _op;
    private static int _divisionCounter = 1;
    
    private void Awake()
    {
        _op = GetComponent<OperatorInitializer>()._operator;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Human")) return;
        
        // Division Handling deletes every n th human
        if (_op.operatorType == OperatorType.Divisor)
        {
            if (_divisionCounter == _op.amount)
            {
                _divisionCounter = 1;
            }
            else
            {
                other.GetComponent<HumanActor>().Kill();
                _divisionCounter++;
            }
        }
        // Multiply Handling
        else
        {
            other.GetComponent<HumanActor>().Multiply(_op.amount);
        }

    }
}
