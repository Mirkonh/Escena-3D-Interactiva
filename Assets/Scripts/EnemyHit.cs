using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindFirstObjectByType<GameOverManager>()
            .ShowGameOver();
        }
    }
}