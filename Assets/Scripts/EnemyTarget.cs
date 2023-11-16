using UnityEngine;
using UnityEngine.AI;

public class EnemyTarget : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] private GameObject target;
    private Vector3 targetPosition;

    void Update()
    {
        targetPosition = target.transform.position;
        agent.SetDestination(targetPosition);
    }
}