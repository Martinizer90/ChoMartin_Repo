using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider))]
public class SpeedPowerUp : MonoBehaviour
{
    [SerializeField]
    private float _speedIncreaseAmount = 20;
    [SerializeField]
    private float _powerupDuration = 3;

    [SerializeField]
    private GameObject _artToDisable = null;

    private Collider _collider;

    private void Awake()
    {
        _collider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerShip playerShip =
            other.gameObject.GetComponent<PlayerShip>();
        if (playerShip != null)
        {
            // powerup sequence
            StartCoroutine(PowerupSequence(playerShip));
        }
    }

    private void StartCoroutine(IEnumerable enumerable)
    {
        throw new NotImplementedException();
    }

    public IEnumerator PowerupSequence(PlayerShip playerShip)
    {
        // soft disable
        _collider.enabled = false;
        _artToDisable.SetActive(false);

        // activate
        ActivatePowerUp(playerShip);

        // wait for some aount of time
        yield return new WaitForSeconds(_powerupDuration);

        // deactivate
        DeactivatePowerUp(playerShip);

        // reenable if desired
        Destroy(gameObject);
    }
    

    private void DeactivatePowerUp(PlayerShip playerShip)
    {
        playerShip.SetMoveSpeed(_speedIncreaseAmount);
    }

    private void ActivatePowerUp(PlayerShip playerShip) 
    {
        playerShip.SetMoveSpeed(-_speedIncreaseAmount);
    }
}
