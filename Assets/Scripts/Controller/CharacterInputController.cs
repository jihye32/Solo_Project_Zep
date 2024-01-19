using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterInputController : CharacterController
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }
    public void OnMove(InputValue value)
    {
        //�Է¹��� ���� Get�� �̿��ؼ� ���Ͱ����� �����´�. normalized�� ������ ũ�⸦ 1�� �������༭ �̵� �ӵ��� ��ȭ�� ���� �ʰ� �����.
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);//�Է��� �Ǿ �̺�Ʈ�� �߻����� �˷��ش�.
    }
    public void OnLook(InputValue value)
    {
        
        Vector2 newAim = value.Get<Vector2>();
        //���콺 ��ǥ�� ���� ��ǥ�� �޾ƿ;���.
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized; //���콺 ��ǥ���� ĳ���� ��ǥ�� ���� ����� ���͸� �������.

        if (newAim.magnitude >= 0.9f)//magnitude�� ũ�⸦ �ǹ���.
        {
            CallLookEvent(newAim);
        }
    }
}
