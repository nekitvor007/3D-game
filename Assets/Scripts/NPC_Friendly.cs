using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Friendly : NPCBase
{
    private bool _inRange;
    void Start()
    {

        _inRange = false;
    }

    void Update()
    {
        if (base.CheckRange())
        {
            _inRange = true;

            Debug.Log($"{gameObject.name}: Hello! Let's chat!");
        }
        else if (_inRange)
        {
            _inRange = false;
            Debug.Log($"{gameObject.name}: Goodby! See you later");
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
            base.StopPlayer();
    }
}
