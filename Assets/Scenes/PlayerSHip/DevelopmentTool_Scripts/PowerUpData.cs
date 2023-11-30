using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="PowerUpData_", menuName = "UnitData/SpeedPowerUp")]
public class PowerUpData : ScriptableObject
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

    private PowerUpType PowerType => _powerupType;
    private float SpeedIncreaseAmount => _speedIncreaseAmount;
    private float Duration => _Duration;
}
