using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndZoneActor : MonoBehaviour
{
    public Transform otherEndZone;
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Operator":
                other.transform.GetComponentInParent<SliderManager>().ResetObjectLocation(other.transform);
                break;
            case "Car":
                other.gameObject.SetActive(false);
                break;
            case "Boat":
                ResetObjectLocation(other.transform);
                break;
            default:
                break;
                
        }
        
    }
    
    public void ResetObjectLocation(Transform obj)
    {
        var temp = obj.position;
        
        obj.position = new Vector3(temp.x,temp.y, otherEndZone.position.z - 6);
    }
    
}
