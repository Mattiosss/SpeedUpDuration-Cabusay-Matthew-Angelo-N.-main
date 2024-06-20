using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float originalSpeed = 10f;  // Original speed of the player
    private float currentSpeed;        // Current speed of the player

    void Start()
    {
        // Set the current speed to the original speed at the start
        currentSpeed = originalSpeed;
    }

    void Update()
    {
        // Example movement logic
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * currentSpeed * Time.deltaTime);
    }

    public void ActivateSpeedBoost(float boostAmount, float duration)
    {
        Debug.Log("Activating speed boost. Amount: " + boostAmount + ", Duration: " + duration);
        // Increase the speed
        currentSpeed += boostAmount;
        Debug.Log("Current speed after boost: " + currentSpeed);
        // Start the coroutine to reset the speed after the boost duration
        StartCoroutine(RemoveSpeedBoostAfterDelay(boostAmount, duration));
    }

    private IEnumerator RemoveSpeedBoostAfterDelay(float boostAmount, float duration)
    {
        // Wait for the duration of the boost
        yield return new WaitForSeconds(duration);
        // Reset the speed by subtracting the boost amount
        currentSpeed -= boostAmount;
        Debug.Log("Speed boost ended. Current speed: " + currentSpeed);
    }
}





