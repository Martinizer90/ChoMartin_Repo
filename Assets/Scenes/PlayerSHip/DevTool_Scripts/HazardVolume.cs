using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardVolume : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // access the Player Controller
        PlayerShip playerShip =
            other.GetComponent<PlayerShip>();
        if (playerShip != null)
        {
            // Kill the player
            playerShip.Kill();
        }
    }
}
