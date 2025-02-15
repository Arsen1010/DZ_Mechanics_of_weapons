using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Machine : MonoBehaviour
{
    [SerializeField] private PointIMP _pointIMP;
    [SerializeField] private Transform _transform;
    [SerializeField] private float _maxBullet = 3f;

    private PointIMP pointIMP;
    private KeyCode _keyCode;
    private Camera _camera;
    private float _counter = 8f;
    private float _delay = 1f;

    private void Start()
    {
        _camera.GetComponent<Camera>();
    }

    private void Delay()
    {
        if (_counter > _delay)
        {
            _counter += Time.deltaTime;
            return false;
        }
        else
        {
            _counter = 8f;

        }
    }

    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Shoot();
        }
    }

    private void Shoot() //סענוכüבא
    {
        for(int i = 0; i < 5; i++)
        {
            Thread.Sleep();
        }
    }
}
