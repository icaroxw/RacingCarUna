using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public Transform firePoint; 
    public float speed = 100f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (bulletPrefab != null && firePoint != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.linearVelocity = firePoint.forward * speed;
            }
        }
    }
}
