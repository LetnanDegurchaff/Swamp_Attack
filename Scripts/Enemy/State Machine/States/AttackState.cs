using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AttackState : State
{
    [SerializeField] private int _damage;
    [SerializeField] private float _delay;
    [SerializeField] private float _startAttackDelay;

    private float _lastAttackTime;
    private Animator _animator;
    private bool isAttacked;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _lastAttackTime = 0;
        isAttacked = true;
    }

    private void Update()
    {
        if ((_lastAttackTime <= (_delay - _startAttackDelay)) && isAttacked == false)
        {
            Target.ApplyDamage(_damage);
            isAttacked = true;
        }

        if (_lastAttackTime <= 0)
        {
            Attack();
            _lastAttackTime = _delay;
            isAttacked = false;
        }

        _lastAttackTime -= Time.deltaTime;
    }

    private void Attack()
    {
        _animator.Play("Attack");
    }
}