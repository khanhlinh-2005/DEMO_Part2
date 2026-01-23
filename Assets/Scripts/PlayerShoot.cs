using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;     // Prefab đạn
    public Transform firePoint;          // Vị trí bắn
    public float shootingInterval = 0.2f; // Thời gian giữa 2 viên

    private float lastBulletTime = 0f;

    void Update()
    {
        // Giữ chuột trái
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime >= shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    void ShootBullet()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
