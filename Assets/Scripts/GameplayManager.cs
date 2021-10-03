using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    // Adjust the speed for the application.
    public float humanSpeed;

    public GameObject[] phasesInOrder;
    

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
