using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int time;
    public TextMeshProUGUI timer;
    float fps = 1f;
    float curTime;



    void Start()
    {
        curTime = 0f;
        SetCountText();
    }


    string toTimeString(int time)
    {
        string ret = ":";
        if (time % 60 < 10)
        {
            ret = ret + "0";
        }
        return (time / 60).ToString() + ret + (time % 60).ToString();
    }

    void SetCountText()
    {
        timer.text = toTimeString(time);
    }

    // Update is called once per frame
    void Update()
    {
        curTime += Time.deltaTime;
        Debug.Log(curTime);
        Debug.Log(fps);

        if (curTime > fps)
        {
            if (time > 0)
            {
                time -= 1;
                SetCountText();
            }
            else
            {
                SceneManager.LoadScene(0);
            }
            curTime = 0f;
        }
    }
}
