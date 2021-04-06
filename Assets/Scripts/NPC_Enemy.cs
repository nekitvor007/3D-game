using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_Enemy : NPCBase
{
    private NavMeshAgent _agent;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (base.CheckRange())
        {
            Debug.Log($"{gameObject.name}: I'm getting closer to you!");
            var point = base._player.transform.position;
            _agent.SetDestination(point);
        }
        else 
        {
            Stop();
            Debug.ClearDeveloperConsole();
        }
    }

    private void Stop()
    {
        _agent.SetDestination(transform.position);
    }

}
