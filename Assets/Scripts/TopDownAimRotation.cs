using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private Transform armPrivot;

    [SerializeField] private SpriteRenderer characterRnderer;

    private TopDownController controller;

    private void Awake()
    {
         controller = GetComponent<TopDownController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotateArm(direction);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRnderer.flipX = Mathf.Abs(rotZ) > 90f;

        armPrivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
