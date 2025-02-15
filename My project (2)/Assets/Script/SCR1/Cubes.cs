using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    public void Chan()
    {
        _meshRenderer.material.color = Color.green;
    }
}
