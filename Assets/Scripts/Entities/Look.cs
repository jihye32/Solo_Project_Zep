using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    private CharacterController _controller;

    private Vector2 _direction = Vector2.zero;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        ApplyLook(_direction);
    }

    private void Start()
    {
        _controller.OnLookEvent += Looked;
    }

    private void Looked(Vector2 vector)
    {
        _direction = vector;
    }

    private void ApplyLook(Vector2 direction)
    {
        float toward = (direction.x > 0) ? 1 : -1;
        transform.localScale = new Vector3(toward, 1, 1);
    }
}
