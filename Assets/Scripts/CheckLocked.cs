using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckLocked : MonoBehaviour
{

    DontDestory levels;
    public UnityEvent onUnlock;
    bool chk = true;
    public int level;

    void Update()
    {
        levels = GameObject.FindObjectOfType<DontDestory>();
        switch (level)
        {
            case 2:
                if (chk && levels.level2 == true)
                {
                    onUnlock.Invoke();
                    chk = false;
                }
                break;
            case 3:
                if (chk && levels.level3 == true)
                {
                    onUnlock.Invoke();
                    chk = false;
                }
                break;
            case 4:
                if (chk && levels.level4 == true)
                {
                    onUnlock.Invoke();
                    chk = false;
                }
                break;
            default:
                break;
        }
    }
}
