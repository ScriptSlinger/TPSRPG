using System;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] float _chaseRange = 5f;

    NavMeshAgent _navMeshAgent;
    float _distanceToPlayer = Mathf.Infinity;
    
    void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        _distanceToPlayer = Vector3.Distance(_target.position, transform.position);
        if (_distanceToPlayer <= _chaseRange)
        {
            _navMeshAgent.SetDestination(_target.position);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, _chaseRange);
    }
}
