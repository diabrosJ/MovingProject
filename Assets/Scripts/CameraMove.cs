using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Transform target;
    [SerializeField]
    private Vector3 offset;

    private void Awake()
    {
        target = GameObject.Find("Player").transform;//플레이어를 찾아감
    }

    private void Update()
    {
        transform.position = target.position + offset;//카메라의 위치를 플레이어 위치로 고정

    }
}
