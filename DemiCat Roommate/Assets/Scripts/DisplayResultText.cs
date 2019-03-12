using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayResultText : MonoBehaviour
{

    public PointKeeper pk;
    public string accepted;
    public string rejected;

    private TextMeshProUGUI tmp;
    
    private void OnEnable()
    {
        tmp = GetComponent<TextMeshProUGUI>();
        tmp.text = pk.currentPoint > 3 ? accepted : rejected;
        Debug.Log("ran");
    }
}
