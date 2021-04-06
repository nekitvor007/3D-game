using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{

    [SerializeField] private float _pickUpRange = 5f;
    [SerializeField] private Transform _player;
    private bool _inRange;

    void Start()
    {
        Debug.ClearDeveloperConsole();

        _inRange = false;
    }
    private void Update()
    {
        Vector3 distanceToPlayer = _player.position - transform.position;
        if (distanceToPlayer.magnitude <= _pickUpRange)
        {
            _inRange = true;
            Debug.Log("Press E to pick up pistol");
            if (Input.GetKeyDown(KeyCode.E))
            {
                PickUp();
            }
        }
        else if(_inRange)
        {
            _inRange = false;
        }
    }


    private void PickUp()
    {
        Destroy(gameObject);
        Debug.Log($"Now you have {gameObject.name}");
    }

}
