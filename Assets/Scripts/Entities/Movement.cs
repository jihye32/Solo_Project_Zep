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
        //+= : 구독하기, -= : 구독 취소하기
        _controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        //구독해서 받은 변수를 지역변수에 저장시켜주기
        _direction = vector;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * speed;
        _rigidbody.velocity = direction;
    }
}
