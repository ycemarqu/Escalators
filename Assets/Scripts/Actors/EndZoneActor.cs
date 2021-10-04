using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

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
                DeleteEveryHumanInside(other.transform);
                break;
            default:
                break;
                
        }
        
    }

    private void DeleteEveryHumanInside(Transform boat)
    {
        for (int i = 0; i < boat.childCount; i++)
        {
            var child = boat.GetChild(i);
            if(child.CompareTag("Human"))
                child.gameObject.GetComponent<HumanActor>().Kill();
        }
    }

    public void ResetObjectLocation(Transform obj)
    {
        var temp = obj.position;
        
        obj.position = new Vector3(temp.x,temp.y, otherEndZone.position.z - 6);
    }
    
}
