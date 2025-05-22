using UnityEngine;

public class EnemyCollisionGameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI; // Assign this in the Inspector

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.LogWarning("Not working");
            // Activate the Game Over UI
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
