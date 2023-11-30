using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider))]
public class SpeedPowerUp : MonoBehaviour
{
    [SerializeField]
    private PowerUpData _data;
    [Header("General Stats")]
    [SerializeField]
    private PowerUpType _powerupType = PowerUpType.Powerup_Normal;

    [SerializeField]
    [Tooltip("Type the number of playership's speed when collide")]
    private float _speedIncreaseAmount = 20;

    [Header("Power Up Stats")]
    [SerializeField][Range(1,30)][Tooltip("Change the duration time when collide with the playerShip")]
    private float _Duration;

    [SerializeField]
    private GameObject _artToDisable = null;

    private Collider _collider;

    private void Awake()
    {
        _collider = GetComponent<Collider>();
        if(_powerupType == PowerUpType.Powerup_Normal)
        {
            Debug.Log("Normal power up activated");
        }
        if (_powerupType == PowerUpType.Powerup_Fast)
        {
            Debug.Log("Fast power up activated");
        }
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
        yield return new WaitForSeconds(_Duration);

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
