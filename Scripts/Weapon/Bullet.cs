using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public abstract class Bullet : MonoBehaviour
{
    [SerializeField] protected int _damage;
    [SerializeField] private float _speed;

    protected Vector2 Direction;

    private void Update()
    {
        transform.Translate(Direction * _speed * Time.deltaTime, Space.World);
    }
}