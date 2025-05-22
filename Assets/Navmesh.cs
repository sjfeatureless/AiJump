using UnityEngine;
using UnityEngine.AI;

public class MoveToClick : MonoBehaviour
{
    private NavMeshAgent agent;

    void Start()
    {
        // Get the NavMeshAgent component attached to the object
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // When the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Raycast from the mouse position to the world
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // If the ray hits something on the NavMesh
            if (Physics.Raycast(ray, out hit))
            {
                // Set the agent's destination to the point the ray hit
                agent.SetDestination(hit.point);
            }
        }
    }
}
