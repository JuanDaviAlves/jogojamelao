using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class CreepController : MonoBehaviour
{
    NavMeshAgent agent;

    public GameObject finalTarget;

    // Start is called before the first frame update
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Start()
    {
        if(finalTarget != null)
        {
            agent.SetDestination(finalTarget.transform.position);
        }
    }
}
