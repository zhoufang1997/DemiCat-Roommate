using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayFeedBackFace : MonoBehaviour
{

    public PointKeeper pk;
    public Sprite correctSprite;
    public Sprite incorrectSprite;

    private SpriteRenderer sr;
    
    void OnEnable()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = pk.correctLastClick ? correctSprite : incorrectSprite;
    }
}
