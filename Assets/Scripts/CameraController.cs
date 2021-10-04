using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 _cameraOffset;
    private int phaseCount = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        _cameraOffset = transform.position - GameplayManager.Instance.escalatorsInOrder[0].transform.position;
        //EscalatorActor.DeactivateEscalator += ChangeCameraLocation;
    }

    public IEnumerator ChangeCameraLocation(Vector3 nextEscalatorPos)
    {
        yield return new WaitForSeconds(1);
        transform.position = _cameraOffset + nextEscalatorPos;
    }
}
