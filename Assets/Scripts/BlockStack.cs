using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackingBlockChecker : MonoBehaviour
{
    void Start()    {
        
    }
    // Update is called once per frame
    void Update()
    {
        // Check if three StackingBlock objects are touching the current object
        if (CheckStackingBlocksTouching())
        {
            // Do something when three StackingBlocks are touching
            Debug.Log("Three StackingBlocks are touching!");
        }
    }

    bool CheckStackingBlocksTouching()
    {
        // Get all colliders touching the current object
        Collider[] colliders = Physics.OverlapBox(transform.position, transform.localScale / 2);

        int stackingBlockCount = 0;

        // Check each collider
        foreach (Collider collider in colliders)
        {
            // Check if the collider has the tag 'StackingBlock'
            if (collider.CompareTag("StackingBlock"))
            {
                stackingBlockCount++;

                // If three StackingBlocks are touching, return true
                if (stackingBlockCount >= 3)
                {
                    return true;
                }
            }
        }

        // Return false if less than three StackingBlocks are touching
        return false;
    }
}
