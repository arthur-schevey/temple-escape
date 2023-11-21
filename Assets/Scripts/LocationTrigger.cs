using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocationTrigger : MonoBehaviour
{

    DontDestory obj;
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindObjectOfType<DontDestory>();
    }

    void Unlock()
    {
        obj.setUnlocked(level);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            int index = SceneManager.GetActiveScene().buildIndex + 1;
            if (index < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(index);
            } else
            {
                print("No scene");
            }
        }
    }
}
