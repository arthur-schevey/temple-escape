using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public TextMeshPro display;

    public bool limitLength = true;

    public int limit = 4;

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
    if (limitLength)
    {
        text += t;

        // Debug log to trace entering text and current text length
        Debug.Log($"Text Entered: {t}, Current Text: {text}, Current Length: {text.Length}");

        if (text.Length == limit)
        {
            // Check if the entered code is correct
            bool isCorrect = CheckCorrectCode(text);

            // Display "Correct" or "Wrong" on the panel
            Clear();
            EnterText(isCorrect ? "Correct" : "Wrong");

            // Start a coroutine to clear the panel after 1.5 seconds
            StartCoroutine(ClearPanelAfterDelay(1.5f));
        }
    }
    else
    {
        text += t;
    }
}

}
