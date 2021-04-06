using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCBase : MonoBehaviour
{
    [SerializeField] protected float _range = 5f;
    [SerializeField] protected Transform _player;


    protected virtual void StopPlayer() 
    {       
        FindObjectOfType<Player>().Stop();
    }

    protected virtual bool CheckRange()
    {
        Vector3 distanceToPlayer = _player.position - transform.position;
        if (distanceToPlayer.magnitude <= _range)
        {
            return true;
        }
        return false;
    }

}
