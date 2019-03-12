using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionAnsweredOnButtonClick : MonoBehaviour
{

    public Animator GMAnimator;
    public int questionNum;

    public void OnClick()
    {
        GMAnimator.SetBool("Question" + questionNum + "Answered", true);
    }
}
