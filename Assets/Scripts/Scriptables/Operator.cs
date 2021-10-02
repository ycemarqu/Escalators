using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum OperatorType{
Multiplier,
Divisor
}

[CreateAssetMenu(fileName = "New Operator", menuName = "Operator")]
public class Operator : ScriptableObject
{
    public OperatorType operatorType;
    public int amount;
    public float size;

}
