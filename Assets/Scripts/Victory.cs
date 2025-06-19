using UnityEngine;

public class Victory : MonoBehaviour
{
    public GameObject victoryUI; // Assign your Victory UI panel in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            victoryUI.SetActive(true); // Show the Victory UI
            Time.timeScale = 0f; // Optional: pause the game
        }
    }
}