using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactKiller : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Human"))
        {
            other.GetComponent<HumanActor>().Kill();
        }
    }
}
