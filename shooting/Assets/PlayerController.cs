using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletSpeed = 150f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }

    void Shoot()
    {
        Ray ray =
Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 targetPoint = hit.point;
            Vector3 direction = (targetPoint - bulletSpawn.position).normalized;
            GameObject bullet =
Instantiate(bulletPrefab,
bulletSpawn.position,
Quaternion.LookRotation(direction));
            Rigidbody rb =
bullet.GetComponent<Rigidbody>();
            rb.velocity = direction * bulletSpeed;
        }

    }
}
