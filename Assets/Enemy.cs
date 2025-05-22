using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform player;

    void Start()
    {
        // Get NavMeshAgent on the enemy
        agent = GetComponent<NavMeshAgent>();

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
        }
    }
}
