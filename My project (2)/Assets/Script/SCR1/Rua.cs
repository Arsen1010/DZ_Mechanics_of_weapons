using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Rua : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;
    [SerializeField] private float _rayLength = 100f;
    [SerializeField] private Camera _camera;
    [SerializeField] private Text _text;

    private Ray _ray;
    private Ray _ray2;
    private Vector3 _mouse;
    private RaycastHit _raycastHit;

    void Update()
    {
        _ray = _camera.ScreenPointToRay(Input.mousePosition);
        _mouse = Input.mousePosition;
        _ray2 = new Ray(_startPoint.position, new Vector3(_mouse.x, _mouse.y, 0));

        Debug.DrawRay(_ray.origin, _ray.direction * _rayLength, Color.red);
        Debug.DrawRay(_ray2.origin, _ray2.direction * _rayLength, Color.green);

        if(Physics.Raycast(_ray, out _raycastHit))
        {
            if(_raycastHit.transform.TryGetComponent(out Cubes cubes))
            {
                cubes.Chan();
            }
        }

        if (Physics.Raycast(_ray2, out _raycastHit))
        {
            if (_raycastHit.transform.TryGetComponent(out Cubes cubes))
            {
                cubes.Chan();
            }
        }
    }
}
