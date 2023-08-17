using System.Collections;
using UnityEngine;

public class ThrowingState : State
{
    [SerializeField] private Transform _throwPoint;
    [SerializeField] private EnemyBullet _bullet;

    private Animator _animator;

    private WaitForSeconds waitForThrow;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        waitForThrow = new WaitForSeconds(0.9f);
    }

    private void OnEnable()
    {
        IsThrowed = false;
        _animator.Play("Attack");

        StartCoroutine(Attack());
    }

    public bool IsThrowed { get; private set; }

    private IEnumerator Attack()
    {
        yield return waitForThrow;

        Instantiate(_bullet, _throwPoint.position, Quaternion.identity);
        IsThrowed = true;
    }
}