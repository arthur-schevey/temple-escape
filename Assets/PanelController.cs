using System.Collections;
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

    // Method to check if the entered code is correct (modify this based on your logic)
    private bool CheckCorrectCode(string code)
    {
        // Replace this with your actual logic to check if the entered code is correct
        return code.Equals("4234");
    }

    // Coroutine method to clear the panel after a delay
    private IEnumerator ClearPanelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Debug log to indicate clearing the panel after a delay
        Debug.Log("Clearing Panel after Delay");

        // Clear the panel after the delay
        Clear();
    }
}
