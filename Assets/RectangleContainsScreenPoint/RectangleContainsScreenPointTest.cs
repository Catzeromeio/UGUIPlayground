using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RectangleContainsScreenPointTest : MonoBehaviour
{
    public RectTransform rect;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       if (RectTransformUtility.RectangleContainsScreenPoint(rect, Input.mousePosition))
        {
            Debug.Log(string.Format("{0} within rect", Input.mousePosition.ToString()));
        }
       else
        {
            Debug.Log(string.Format("{0} out of rect", Input.mousePosition.ToString()));
        }
    }
}
