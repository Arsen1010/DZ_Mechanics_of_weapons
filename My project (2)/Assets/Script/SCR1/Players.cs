using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    private const string _lineX = "Mouse X";
    private const string _lineY = "Mouse Y";

    [SerializeField] private float _sensitivity;

    private int _minRotation = -45;
    private int _maxRotation = 45;
    private float _mouseX;
    private float _mouseY;
    private float _rotationX = 0.0f;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        _mouseX = Input.GetAxis(_lineX);
        _mouseY = Input.GetAxis(_lineY);

        transform.parent.Rotate(Vector3.up * _mouseX * _sensitivity * Time.deltaTime);

        _rotationX -= _mouseY * _sensitivity * Time.deltaTime;
        _rotationX = Mathf.Clamp(_rotationX, _minRotation, _maxRotation);
        transform.localRotation = Quaternion.Euler(_rotationX, 0f, 0f);
    }

}
