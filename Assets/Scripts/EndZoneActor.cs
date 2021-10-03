using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndZoneActor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Operator":
                SliderManager.Instance.ResetObjectLocation(other.transform);
                break;
            case "Car":
                other.gameObject.SetActive(false);
                break;
            
            default:
                break;
                
        }
        
    }
}
