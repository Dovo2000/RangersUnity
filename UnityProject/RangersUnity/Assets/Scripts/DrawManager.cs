using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawManager : MonoBehaviour
{
    private Camera _cam;
    [SerializeField] private Line _LinePrefab;

    public const float RESOLUTION = 0.1f;

    private Line _currentLine;

    void Start()
    {
        _cam = Camera.main;
    }


    void Update()
    {
        Vector2 mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            _currentLine = Instantiate(_LinePrefab, mousePos, Quaternion.identity);
        }

        if(Input.GetMouseButton(0))
        {
            _currentLine.SetPosition(mousePos);
        }
    }
}
