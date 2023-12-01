using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform _bulletSpawnPoint;
    public GameObject _bulletPrefab;
    public float _bulletSpeed = 10;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(_bulletPrefab, _bulletSpawnPoint.position, _bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = _bulletSpawnPoint.forward * _bulletSpeed;
        }
    }
}
