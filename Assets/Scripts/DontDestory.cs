using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DontDestory : MonoBehaviour
{
    private static DontDestory reference = null;
    public bool level2 = false;
    public bool level3 = false;
    public bool level4 = false;
    public bool restart = false;


    public void Restart_Levels()
    {
        if (restart)
        {
            level2 = false;
            level3 = false;
            level4 = false;
            restart = false;
        }
    }


    public void setUnlocked(int i)
    {
        switch (i)
        {
            case 2:
                level2 = true;
                break;
            case 3:
                level3 = true;
                break;
            case 4:
                level4 = true;
                break;
            case 5:
                restart = true;
                break;
            default:
                break;
        }
    }

    void Awake()
    {
        if (reference == null)
        {
            reference = this;
            DontDestroyOnLoad(this);
        } 
        else
        {
            Destroy(this.gameObject);
        }
    }
}
