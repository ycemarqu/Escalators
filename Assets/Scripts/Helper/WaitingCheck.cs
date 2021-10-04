using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingCheck : MonoBehaviour
{
    public bool isThereAnyoneWaiting = false;
    private bool _temp = false;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Human"))
        {
            _temp = true;
            StartCoroutine(Expand());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Human"))
        {
            _temp = false;
            isThereAnyoneWaiting = false;
        }
    }

    IEnumerator Expand()
    {
        yield return new WaitForSeconds(2f);
        isThereAnyoneWaiting = _temp;

    }
    
}
