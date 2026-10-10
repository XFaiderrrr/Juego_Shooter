using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    
    public NavMeshAgent navMeshAgent;
    public GameObject destination1;

    void Start()
    {
        
    }

    void Update()
    {
        navMeshAgent.destination = destination1.transform.position;
    }
}
