using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevel : MonoBehaviour
{
    [SerializeField] private Transform parentListObj;
    public int countObj;
    public int collectObj;
    private bool canCheck = true;
    
    public void Start()
    {
        canCheck = true;

        collectObj = 0;
    }

    public void RemoveObject(GameObject obj)
    {
        Destroy(obj.gameObject);
        collectObj++;
    }
}
