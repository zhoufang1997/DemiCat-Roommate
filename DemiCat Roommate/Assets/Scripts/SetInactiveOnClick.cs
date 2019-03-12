using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInactiveOnClick : MonoBehaviour
{
    public void OnClick()
    {
        gameObject.SetActive(false);
    }
}
