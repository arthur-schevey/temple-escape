using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public TextMeshPro display;

    public bool limitLength = true;

    public int limit = 3;

    private string text = "";
    
    // Update is called once per frame
    void Update()
    {
        display.text = text;
    }

    public string GetText()
    {
        return text;
    }

    public void Clear()
    {
        text = "";
    }

    public void EnterText(string t)
    {
        if (limitLength && text.Length == limit)
        {
            Clear();
        }
        text += t;
    }
}
