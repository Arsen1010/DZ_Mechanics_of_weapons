using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Shotgun : MonoBehaviour
{
    [SerializeField] private PointIMP _spherePrebaf;
    [SerializeField] private Transform _startPointRay;
    //[SerializeField] private Text _nowButtonCountText;

    //private KeyCode _relodKey = KeyCode.R;
    private RaycastHit _raycastHit;
    private Ray _ray;
    private Camera _camera;
    private Vector3 _aimPosition;
    private int _sizeAim = 20;
    private float _aimPositionDrawX;
    private float _aimPositionDrawY;
    private string _aimChar = "+";
    private PointIMP _tempPointImpact;
    //private int _maxBullet = 5;
    //private int _nowBullets;

    private void Start()
    {
        _camera = GetComponentInParent<Camera>();
        //_nowBullets = _maxBullet;
        //ChangeTextBullet(_nowBullets);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) /*&& _nowBullets > 0*/)
        {
            Debug.Log("1111");
            Shoot();
        }

    //    if (Input.GetKeyDown(_relodKey))
    //    {
    //        _nowBullets = _maxBullet;
    //        ChangeTextBullet(_nowBullets);
    //    }
    }

    private void Shoot() //стрельба
    {
        //_aimPosition = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0); // нахождения позиции центра екрана

        for (int i = 0; i < 5; i++)
        {
            //_ray =_camera.ScreenPointToRay(_aimPosition);  // испускания луча
            _ray = new Ray(_startPointRay.position, _camera.transform.forward += GetRandomVector());

            if (Physics.Raycast(_ray, out _raycastHit))
            {
                _tempPointImpact = Instantiate(_spherePrebaf);
                _tempPointImpact.transform.position = _raycastHit.point;
            }
        }

        //_nowBullets--;
        //ChangeTextBullet(_nowBullets);

        Debug.DrawRay(_ray.origin, _ray.direction * 1000); // прорисовка луча
    }

    private Vector3 GetRandomVector()
    {
        return new Vector3(
            Random.Range(-0.05f, 0.05f),
            Random.Range(-0.05f, 0.05f),
            Random.Range(-0.05f, 0.05f)
            );
    }

    private void OnGUI() // прорисовка прицела
    {
        _aimPositionDrawX = _camera.pixelWidth / 2 - _sizeAim / 4;
        _aimPositionDrawY = _camera.pixelHeight / 2 - _sizeAim / 2;

        GUI.Label(new Rect(_aimPositionDrawX, _aimPositionDrawY, _sizeAim, _sizeAim), _aimChar); // прорисовка на канвасе значка прицела
    }

    private void ChangeTextBullet(int count)
    {
    //    _nowButtonCountText.text = Convert.ToString(count);
    }
}
