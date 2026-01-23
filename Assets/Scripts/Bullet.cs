using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 8f;
    public float destroyY = 6f;   // Giới hạn huỷ đạn

    void Update()
    {
        // Đạn bay lên
        transform.Translate(Vector2.up * flySpeed * Time.deltaTime);

        // Ra khỏi màn hình thì huỷ
        if (transform.position.y > destroyY)
        {
            Destroy(gameObject);
        }
    }
}
