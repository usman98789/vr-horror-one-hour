using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float radius;
    [SerializeField] private float avoidanceRadius;
    [SerializeField] GameObject jump;

    private NavMeshAgent agent;
    [SerializeField] Transform target;
    private Animator anim;

    private void Start() {        
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    private void Update() {
        MoveToTarget();
        RotateToTarget();
        float distanceToTarget = Vector3.Distance(transform.position, target.position);
        if (distanceToTarget <= agent.stoppingDistance) {
            jump.SetActive(true);
        }
    }

    private void RotateToTarget() {
        Vector3 direction = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = rotation;
    }

    private void MoveToTarget() {
        agent.SetDestination(target.position);
    }

}
