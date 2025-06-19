using UnityEngine;
using UnityEngine.AI;

public class MoveToClick : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }

        // Improved walking animation logic
        bool isWalking = agent.hasPath && agent.remainingDistance > agent.stoppingDistance;
        animator.SetBool("isWalking", isWalking);
    }
}
