using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class State : StateMachineBehaviour
{
    private float timer;
    public List<Transform> points = new List<Transform>();

    private NavMeshAgent agent;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = 0;
        Transform pointsObject = GameObject.FindGameObjectWithTag("Points").transform;
        foreach (Transform t in pointsObject)
        {
            points.Add((t));
        }

        agent = animator.GetComponent<NavMeshAgent>();
        
    }
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
            agent.SetDestination(points[Random.Range(0, points.Count)].position);
        //if (timer > 0) animator.SetBool("isPatruling", true);
        }
}