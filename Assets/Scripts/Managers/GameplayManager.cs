using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    // Adjust the speed for the application.
    public float humanSpeed;

    public GameObject[] phasesInOrder;
    public GameObject[] escalatorsInOrder;
    public Camera mainCamera;

    
    [NonSerialized]public int _humanCount = 0;
    [NonSerialized]public int CurrentPhase = 1;

    #region Singleton

    private static GameplayManager instance = null;

    private CameraController _cameraController;

    // Game Instance Singleton
    public static GameplayManager Instance
    {
        get
        { 
            return instance; 
        }
    }

    #endregion
    
    private void Awake()
    {
        _cameraController = mainCamera.GetComponent<CameraController>();
        _humanCount = GameObject.FindGameObjectsWithTag("Human").Length;
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        EscalatorActor.DeactivateEscalator += IncrementCurrentPhase;
    }

    void Update()
    {
        Debug.Log($"There are {_humanCount} humans ingame");
    }

    private void IncrementCurrentPhase()
    {
        if (CurrentPhase < escalatorsInOrder.Length)
        {
            StartCoroutine(_cameraController.ChangeCameraLocation(escalatorsInOrder[CurrentPhase].transform.position));
            CurrentPhase++;
        }
    }
}
