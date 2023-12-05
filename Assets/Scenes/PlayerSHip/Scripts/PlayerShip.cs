using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    [Header("Player General States")]
    [Tooltip("Playership will move when typing negative numbers")]
    [SerializeField] float _moveSpeed = -35f;
    [Tooltip("Adjust the speed for turning the Playership")]
    [SerializeField] float _turnSpeed = 3;

    public Transform _bulletSpawnPoint;
    public GameObject _bulletPrefab;
    public float _bulletSpeed = 10;

    Rigidbody _rb = null;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MoveShip();
        TurnShip();
    }

    void MoveShip()
    {
        // S/Down = -1; W/Up = 1, None = 0. Scale by moveSpeed
        float moveAmountThisFrame = Input.GetAxisRaw("Vertical") * _moveSpeed;
        Vector3 moveDirection = transform.forward * moveAmountThisFrame;
        _rb.AddForce(moveDirection);
    }

    void TurnShip()
    {
        float turnAmountThisFrame = Input.GetAxisRaw("Horizontal") * _turnSpeed;
        Quaternion turnOffset = Quaternion.Euler(0, turnAmountThisFrame, 0);
        _rb.MoveRotation(_rb.rotation * turnOffset);
    }

    public void SetMoveSpeed(float newSpeedAdjustment)
    {
        _moveSpeed += newSpeedAdjustment;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(_bulletPrefab, _bulletSpawnPoint.position, _bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = _bulletSpawnPoint.forward * _bulletSpeed;
        }
    }
}
