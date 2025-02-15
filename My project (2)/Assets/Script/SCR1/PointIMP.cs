using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointIMP : MonoBehaviour
{
    [SerializeField] private int _time;

    public void Start()
    {
        Destroy(gameObject, _time);
    }
}
