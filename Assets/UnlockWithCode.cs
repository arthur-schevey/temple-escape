using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class UnlockWithCode : MonoBehaviour
{

public PanelController panelController;
public string unlockCode = "";
public UnityEvent onUnlock;

private bool locked = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (locked && panelController.GetText().Equals(unlockCode))
{
    onUnlock.Invoke();
    locked = false; // Only invoke once
}
    }
}
