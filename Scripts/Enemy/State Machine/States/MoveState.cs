﻿using UnityEngine;

public class MoveState : State
{
    [SerializeField] private float _speed;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _animator.Play("Walk");
    }

    private void Update()
    {
        if (Target != null)
            transform.position = 
                Vector2.MoveTowards(transform.position, Target.transform.position, _speed * Time.deltaTime);
    }
}