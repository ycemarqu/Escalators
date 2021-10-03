using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderManager : MonoBehaviour
{
    public Transform resetObject;

    #region Singleton

    private static SliderManager instance = null;
    public static SliderManager Instance
    {
        get
        { 
            return instance; 
        }
    }
    private void Awake()
    {
        instance = this;
    }

    #endregion

    public void ResetObjectLocation(Transform obj)
    {
        var temp = obj.position;
        
        obj.position = new Vector3(temp.x,temp.y,resetObject.position.z);
    }
}
