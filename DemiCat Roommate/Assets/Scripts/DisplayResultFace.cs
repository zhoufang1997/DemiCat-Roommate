using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayResultFace : MonoBehaviour
{

    public PointKeeper pk;

    public Sprite accepted;
    public Sprite rejected;

    private SpriteRenderer sr;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = pk.currentPoint > 3 ? accepted : rejected;
    }
}
