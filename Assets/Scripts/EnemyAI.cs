using System;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform _target;
    NavMeshAgent _navMeshAgent;

    void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        _navMeshAgent.SetDestination(_target.position);
    }
}
