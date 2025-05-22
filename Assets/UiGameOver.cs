using UnityEngine;

public class EnemyCollisionGameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI; // Assign this in the Inspector
    [SerializeField] private Transform player; // Assign the Player transform in the Inspector
    [SerializeField] private float gameOverDistance = 1f; // Distance at which to trigger Game Over
    private bool hasGameOverTriggered = false;

    void Update()
    {
        if (hasGameOverTriggered || player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= gameOverDistance)
        {
            hasGameOverTriggered = true;
            Debug.Log("Player is within range. Game Over triggered.");

            if (gameOverUI != null)
            {
                gameOverUI.SetActive(true);
            }
            else
            {
                Debug.LogWarning("Game Over UI object is not assigned!");
            }
        }
    }
}
