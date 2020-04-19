using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossMovement : MonoBehaviour
{
    [SerializeField] Transform target;
    private NavMeshAgent agent;
    private Vector3 pos;
    Animator anim;
    
    private void Start() {
        pos = transform.position;
        anim = GetComponent<Animator>();
    }

    private void Update() {
        pos = transform.position;

        float radialDistance = Vector3.Distance(target.position, pos);

        if (radialDistance < 2) {
            Debug.Log("<10");
            anim.SetTrigger("Attack");
        }
        else if (radialDistance < 5) {
            Debug.Log("<20");
            agent = GetComponent<NavMeshAgent>();
            if (agent != null) {
                agent.SetDestination(target.position);
                anim.SetFloat("Speed", 1.0f);
            }
        }
        else if (radialDistance < 10) {
            Debug.Log("<30");
            anim.SetFloat("Speed", 0.0f);
            anim.SetBool("isAlert", true);
        } else {
            Debug.Log(">30");
            anim.SetBool("isAlert", false);
            anim.SetFloat("Speed", 0.0f);
        }
        
    }

    private void Attack() {
        

    }
}
