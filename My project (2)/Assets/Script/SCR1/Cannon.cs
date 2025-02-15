using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class Cannon : MonoBehaviour
{
    [SerializeField] private PointIMP _pointIMP;
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Text _text;

    private KeyCode _keyCode;
    private RaycastHit _raycastHit;
    private Ray _ray;
    private Camera _camera;
    private int _novu;
    private PointIMP _spointIMP;

    private void Start()
    {
        _camera = GetComponentInParent<Camera>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot() //סענוכüבא
    {
        _ray = new Ray(_startPoint.position, _camera.transform.forward += GetRandomVector());

        if (Physics.Raycast(_ray, out _raycastHit))
        {
            _spointIMP = Instantiate(_pointIMP);
            _spointIMP.transform.position = _raycastHit.point;
        }
    }

    private Vector3 GetRandomVector()
    {
        return new Vector3();
    }
}
