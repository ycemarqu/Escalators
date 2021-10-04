using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatActor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Human"))
        {
            other.GetComponent<HumanActor>().isActive = false;
            other.transform.SetParent(this.transform);
        }
    }
}
