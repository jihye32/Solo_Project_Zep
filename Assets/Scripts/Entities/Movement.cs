using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController _controller;

    private Vector2 _direction = Vector2.zero;
    private Rigidbody2D _rigidbody;

    [SerializeField] private int speed = 5;
    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        ApplyMovement(_direction);
    }

    private void Start()
    {
        //+= : �����ϱ�, -= : ���� ����ϱ�
        _controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        //�����ؼ� ���� ������ ���������� ��������ֱ�
        _direction = vector;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * speed;
        _rigidbody.velocity = direction;
    }
}
