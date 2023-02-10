using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Camera _camera;
    public Color[] _color;

    public static CameraFollow instance;

    public GameObject point;

    private void Awake()
    {
        instance = this;
    }

    public bool checkStep;
    public static int cl;
    private void Start()
    {
        checkStep = false;
        _camera.backgroundColor = _color[Random.Range(0, _color.Length)];
    }
    private void Update()
    {
        if (checkStep == true)
        {
            point.transform.position = point.transform.position + new Vector3(0, -3, 0);
            checkStep = false;
        }
        transform.position = Vector3.MoveTowards(transform.position, point.transform.position, 0.5f);
    }
}
