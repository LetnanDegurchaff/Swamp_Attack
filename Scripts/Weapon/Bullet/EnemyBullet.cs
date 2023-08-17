using UnityEngine;

public class EnemyBullet : Bullet
{
    private void Awake()
    {
        Direction = Vector2.right;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player enemy))
        {
            enemy.ApplyDamage(_damage);

            Destroy(gameObject);
        }
    }
}
