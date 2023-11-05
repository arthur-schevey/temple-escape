using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPuzzleScript : MonoBehaviour
{
    public GameObject ball;
    public GameObject platform1;
    public GameObject platform2;
    public GameObject platform3;
    private float angle = 70f;
    private Vector3 spawnPoint;
    private float killPoint;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = new Vector3(-1.5f, 4.5f, 11f);
        killPoint = 0.25f;
    }

    // Update is called once per frame
    void Update()
    {
        BallRespawn();
    }

    public void MovePlatforms() {
        platform1.transform.Rotate(Vector3.forward * angle);
        platform2.transform.Rotate(Vector3.forward * angle);
        platform3.transform.Rotate(Vector3.forward * angle);
        angle *= -1;
    }

    public void BallRespawn() {
       if (ball.transform.position.y <= killPoint) {
        ball.transform.position = spawnPoint;
       }
    }

}
