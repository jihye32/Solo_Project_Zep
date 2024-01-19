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
        //입력받은 값을 Get을 이용해서 벡터값으로 가져온다. normalized는 벡터의 크기를 1로 고정해줘서 이동 속도의 변화를 주지 않게 만든다.
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);//입력이 되어서 이벤트가 발생함을 알려준다.
    }
    public void OnLook(InputValue value)
    {
        
        Vector2 newAim = value.Get<Vector2>();
        //마우스 좌표를 월드 좌표로 받아와야함.
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized; //마우스 좌표에서 캐릭터 좌표를 빼서 연결된 벡터를 만들어줌.

        if (newAim.magnitude >= 0.9f)//magnitude는 크기를 의미함.
        {
            CallLookEvent(newAim);
        }
    }
}
