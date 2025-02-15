using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(CharacterController))]

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;

    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";

    private CharacterController _characterController;
    private float _directionHorizontal;
    private float _directionVertical;
    private Vector3 _move;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        _directionHorizontal = Input.GetAxis(Horizontal);
        _directionVertical = Input.GetAxis(Vertical);

        _move = transform.forward * _directionVertical + transform.right * _directionHorizontal;
        _characterController.Move(_move * _speed * Time.deltaTime);
    }
}
