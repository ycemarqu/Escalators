using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;

public class HumanActor : MonoBehaviour
{
    
    private Transform firstTarget;
    private bool _createdThisTurn = false;
    private CharacterController _characterController;
    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _characterController.SimpleMove((transform.right) * GameplayManager.Instance.humanSpeed);
    }

    public void Kill()
    {
        GameplayManager.Instance._humanCount--;
        Destroy(this.gameObject);
    }

    public void Multiply(int amount)
    {
        if (_createdThisTurn) return;
        GameplayManager.Instance._humanCount += amount-1;
        
        for (int i = 0; i < amount-1; i++)
        {
            var newHuman = ObjectPool._pool.Dequeue();
            var pos = transform.position;
            newHuman.transform.position = new Vector3(pos.x - 0.1f, pos.y, pos.z);
            newHuman.SetActive(true);
            newHuman.GetComponent<HumanActor>()._createdThisTurn = true;
        }
    }
}
