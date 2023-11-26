using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRoomLoader : MonoBehaviour
{
    public GameObject player;
    public GameObject spawn;

    // Start is called before the first frame update
    void Start()
    {
        while (player.transform.localPosition != spawn.transform.localPosition)
        {
            Debug.Log("moving player to spawn");
            player.transform.localPosition = spawn.transform.localPosition;
        }  
    }

    // Update is called once per frame
    void Update()
    {
    }
}
