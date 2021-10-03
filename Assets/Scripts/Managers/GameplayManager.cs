using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    // Adjust the speed for the application.
    public float humanSpeed;

    public GameObject[] phasesInOrder;

    
    public int _humanCount = 0;
    

    #region Singleton

    private static GameplayManager instance = null;
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
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        _humanCount = GameObject.FindGameObjectsWithTag("Human").Length;
        Debug.Log($"Human Count is:{_humanCount}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
