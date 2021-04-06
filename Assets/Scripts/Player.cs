using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    [SerializeField] private Material _movementTexture;

    private Material _defaultTexture;
    private NavMeshAgent _agent;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _defaultTexture = GetComponent<Renderer>().material;
    }

    public void Stop()
    {
        _agent.SetDestination(transform.position);
    }

    private void Update()
    {
        if (!_agent.hasPath)
        {
            gameObject.GetComponent<Renderer>().material = _defaultTexture;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material = _movementTexture;
        }
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                _agent.SetDestination(hit.point);
            }
        }
    }
}
