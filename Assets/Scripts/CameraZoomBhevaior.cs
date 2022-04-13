using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CameraZoomBhevaior : MonoBehaviour
{
    private Camera _camera;
    [SerializeField]
    private Vector2 _referenceAspectRatio;
    private Vector3 _startPos;
    private float _refRatio;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();
        _refRatio = _referenceAspectRatio.x / _referenceAspectRatio.y;
        _startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        double ratio = _refRatio / _camera.aspect;
        ratio = Math.Round(ratio, 4);

        Vector3 scaledPosition = _startPos * (float)ratio;
    }
}
