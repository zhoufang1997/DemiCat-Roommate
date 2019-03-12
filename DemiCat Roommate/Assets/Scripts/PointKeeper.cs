using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointKeeper : MonoBehaviour
{
    public int currentPoint;
    public bool correctLastClick;

    void Start()
    {
        currentPoint = 0;
        correctLastClick = false;
    }
}
