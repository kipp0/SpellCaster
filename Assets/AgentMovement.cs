using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMovement : MonoBehaviour
{
    [SerializeField] Transform target;
       private NavMeshAgent agent;
       private void Start() {
            agent = GetComponent<NavMeshAgent>();
            if (agent != null) { 
                agent.SetDestination(target.position);
            } 
        }
}
