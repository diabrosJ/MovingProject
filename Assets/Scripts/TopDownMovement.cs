using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    // 실제로 이동이 일어날 컴포넌트

    private TopDownController controller;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        //주로 내 컴포넌트 안에서 끝나는것

        // controller 랑 topdownMovement랑 같은 게임오브젝트 안에 있다라는 가정
        controller = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }
    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }
    private void FixedUpdate()
    {
        //FixUpdate는 물리업데이트 관련
        //rigidbody의 값을 바꾸니까 FixUpdate
        ApplyMovement(movementDirection);
    }
    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        movementRigidbody.velocity = direction;
    }
}