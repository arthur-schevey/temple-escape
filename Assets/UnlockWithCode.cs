using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnlockWithCode : MonoBehaviour
{
    public PanelController panelController;
    public string unlockCode = "4444";
    public UnityEvent onUnlock;

    private bool locked = true;
    public GameObject door; // Reference to the door GameObject

    // Start is called before the first frame update
    void Start()
    {
        // If door reference is not set, try to find it by tag
        if (door == null)
        {
            door = GameObject.FindGameObjectWithTag("Door");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (locked && panelController.GetText().Equals(unlockCode))
        {
            onUnlock.Invoke();
            HideDoor(); // Hide the door
            locked = false; // Only invoke once
        }
    }

    // Method to hide or destroy the door
    private void HideDoor()
    {
        if (door != null)
        {

            Destroy(door);
        }
    }
}
