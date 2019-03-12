using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPointOnCorrectButtonClick : MonoBehaviour
{

    public PointKeeper pk;

    public void OnCorrectClick()
    {
        pk.currentPoint++;
        pk.correctLastClick = true;
    }

    public void OnIncorrectClick()
    {
        pk.correctLastClick = false;
    }
}
