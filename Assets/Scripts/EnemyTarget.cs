using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTarget : MonoBehaviour
{
    private Transform playerTarget;
    private NavMeshAgent agent;
    private bool searchingForPlayer = false;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        if (playerTarget == null )
        {
            if (!searchingForPlayer )
            {
                searchingForPlayer = true;
                StartCoroutine(SearchForPlayer());
            }
        }
    }

    void Update()
    {
        agent.SetDestination(playerTarget.position);
    }

    IEnumerator SearchForPlayer()
    {
        GameObject searchResult = GameObject.FindGameObjectWithTag("Player");
        if (searchResult == null)
        {
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(SearchForPlayer());
        }
        else
        {
            playerTarget = searchResult.transform;
            searchingForPlayer = false;
            yield return false;
        }
    }
}