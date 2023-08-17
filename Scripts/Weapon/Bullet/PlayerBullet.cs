using UnityEngine;

public class PlayerBullet : Bullet
{
    private void Awake()
    {
        Direction = Vector2.left;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(_damage);

            Destroy(gameObject);
        }
    }
}