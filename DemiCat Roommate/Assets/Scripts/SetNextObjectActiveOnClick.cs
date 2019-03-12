using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNextObjectActiveOnClick : MonoBehaviour
{
    public GameObject nextQuestion;

    public void OnClick()
    {
        nextQuestion.SetActive(true);
    }
}
