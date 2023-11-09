using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRoomObstacle : MonoBehaviour
{
    public GameObject ball;
    public GameObject spawn;
    private Vector3 spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = spawn.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider obs)
    {
        if(obs.gameObject.CompareTag("PuzzleBall"))
            ball.transform.position = spawnPoint;
    }
}
