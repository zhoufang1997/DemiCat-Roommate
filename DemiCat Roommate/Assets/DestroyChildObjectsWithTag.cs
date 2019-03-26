using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyChildObjectsWithTag : MonoBehaviour
{
    public string searchTag;
 
    public void FindObjectwithTag(string _tag)
    {
        Transform parent = transform;
        DestroyChildWithTag(parent, _tag);
    }
 
    public void DestroyChildWithTag(Transform parent, string _tag)
    {
        for (int i = 0; i < parent.childCount; i++)
        {
            Transform child = parent.GetChild(i);
            if (child.tag == _tag)
            {
                DestroyImmediate(child.gameObject);
            }
        }
    }
}
