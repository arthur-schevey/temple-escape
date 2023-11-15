using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestory : MonoBehaviour
{


    public bool level1 = false;
    public bool level2 = false;
    public bool level3 = false;
    public bool level4 = false;

    GameObject obj;


    void setUnlocked(int i)
    {
        switch (i)
        {
            case 1:
                level1 = true;
                break;
            case 2:
                level2 = true;
                break;
            case 3:
                level3 = true;
                break;
            case 4:
                level4 = true;
                break;
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(obj);
    }
}