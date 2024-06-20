using UnityEngine;

public class SpeedBoostItem : MonoBehaviour
{
    public float speedBoostAmount = 5f;    // Amount to increase the speed
    public float speedBoostDuration = 2f;  // Duration of the speed boost

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player collided with the item
        if (other.CompareTag("Player"))
        {
            // Get the Player component
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                Debug.Log("Player touched the SpeedBoostItem. Applying speed boost.");
                // Apply the speed boost to the player
                player.ActivateSpeedBoost(speedBoostAmount, speedBoostDuration);
                // Destroy the speed boost item to make it disappear
                Destroy(gameObject);
                Debug.Log("SpeedBoostItem destroyed.");
            }
        }
    }
}




