using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeCanvusOnRuntime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 rawMin = Camera.main.ScreenToWorldPoint(Vector2.zero);
        Vector2 rawMax = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        Vector2 rawRange = rawMax - rawMin;
        Vector2 referenceSize = new Vector2(1600, 900);
        float scale = rawRange.x / referenceSize.x;
        transform.localScale = new Vector3(scale, scale, 1);
    }
}
