using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform player;
    private Animator animator; // Add this line

    void Start()
    {
        // Get NavMeshAgent on the enemy
        agent = GetComponent<NavMeshAgent>();

        // Get Animator on the enemy
        animator = GetComponent<Animator>(); // Add this line

        // Find the player by tag
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.transform;
        }
        else
        {
            Debug.LogWarning("Player object not found! Make sure the player is tagged as 'Player'.");
        }
    }

    void Update()
    {
        if (player != null)
        {
            // Set the destination to the player's position
            agent.SetDestination(player.position);

            // Check if the agent is moving and update animation
            bool isWalking = agent.velocity.magnitude > 0.1f;
            animator.SetBool("isWalking", isWalking); // Add this line
        }
        else
        {
            // If no player, set to idle
            animator.SetBool("isWalking", false); // Add this line
        }
    }
}
