using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="PowerUpData_", menuName = "UnitData/SpeedPowerUp")]
public class PowerUpData : ScriptableObject
{
    [Header("General Stats")]
    [SerializeField]
    private PowerUpType _powerupType = PowerUpType.Powerup_Normal;

    [SerializeField]
    [Tooltip("Type the number of playership's speed when collide")]
    private float _speedIncreaseAmount = 20;

    [Header("Power Up Stats")]
    [SerializeField][Range(1,30)][Tooltip("Change the duration time when collide with the playerShip")]
    private float _Duration;


    public PowerUpType PowerType => _powerupType;
    public float SpeedIncreaseAmount => _speedIncreaseAmount;
    public float Duration => _Duration;
}
