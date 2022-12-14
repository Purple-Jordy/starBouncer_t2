using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allRight : MonoBehaviour
{
    private LineRenderer lr;
    private Transform[] points;
    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    public void SetupLine(Transform[] points)
    {
        lr.positionCount = points.Length;
        this.points = points; 
    }

    private void Update()
    {
        for (int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
        }
    }
}
