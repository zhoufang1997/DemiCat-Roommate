using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[ExecuteInEditMode]
public class ButtonGenerator : MonoBehaviour
{
    [Range(1,4)] public int numberOfButtons;
    public GameObject buttonPrefab;

    private GameObject[] _buttons;
    private RectTransform _transform;
    public Vector2 _size;
    private Vector2 _sizeF;
    private int _numberOfButtonsF;

    private void Start()
    {
        this.enabled = false;
    }

    // Update is called once per frame
    private void Update()
    {
        _transform = GetComponent<RectTransform>();
        _size = _transform.sizeDelta;
        if (_sizeF != _size || _numberOfButtonsF != numberOfButtons)
        {
            DestroyChildrenWithTag("Button");
            GenerateButtons(numberOfButtons, _size);
        }
        _numberOfButtonsF = numberOfButtons;
        _sizeF = _size;
    }

    private void GenerateButtons(int numberOfButtons, Vector2 fieldSize)
    {
        _buttons = new GameObject[numberOfButtons];
        Vector2 buttonSize = DetermineButtonSize(numberOfButtons);
        Vector2[] buttonPositions = DetermineButtonPositions(numberOfButtons, fieldSize, buttonSize);
        
        for (int i = 0; i < numberOfButtons; i++)
        {
            _buttons[i] = Instantiate(buttonPrefab, Vector2.zero, Quaternion.identity);
            _buttons[i].transform.SetParent(_transform, false);

            RectTransform buttonTransform = _buttons[i].GetComponent<RectTransform>();
            buttonTransform.localPosition = buttonPositions[i];
            buttonTransform.sizeDelta = buttonSize;
        }
    }

    private Vector2 DetermineButtonSize(int numberOfButtons)
    {
        var buttonSize = numberOfButtons < 4 ? new Vector2(_size.x / numberOfButtons, _size.y) : new Vector2(_size.x / 2, _size.y / 2);
        return buttonSize;
    }

    //manual rn. need to be updated to algorithm. possibly by somehow calculating optimal 2d array
    private static Vector2[] DetermineButtonPositions(int numberOfButtons, Vector2 fieldSize, Vector2 buttonSize)
    {
        var buttonPositions = new Vector2[numberOfButtons];
        if (numberOfButtons < 4)
        {
            float positionY = 0;
            for (int i = 0; i < buttonPositions.Length; i++)
            {
                float positionX = -fieldSize.x / 2 + buttonSize.x * (i + 0.5f);
                buttonPositions[i] = new Vector2(positionX, positionY);
            }
        }
        else
        {
            float y0 = fieldSize.y / 4f;
            float y1 = -y0;
            float x0 = fieldSize.x / 4;
            float x1 = -x0;
            buttonPositions[0] = new Vector2(x0, y0);
            buttonPositions[1] = new Vector2(x1, y0);
            buttonPositions[2] = new Vector2(x0, y1);
            buttonPositions[3] = new Vector2(x1, y1);
        }

        return buttonPositions;
    }

    private void DestroyChildrenWithTag(string _tag)
    {
        var parent = transform;
        foreach (var button in GetChildrenWithTag(parent, _tag))
        {
            DestroyImmediate(button);
        }
    }

    private static IEnumerable<GameObject> GetChildrenWithTag(Transform parent, string _tag)
    {
        var buttons = new List<GameObject>();
        for (var i = 0; i < parent.childCount; i++)
        {
            var child = parent.GetChild(i);
            if (child.CompareTag(_tag))
            {
                buttons.Add(child.gameObject);
            }
        }

        return buttons;
    }

}
