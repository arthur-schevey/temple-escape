using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallPuzzleScript : MonoBehaviour
{
    public GameObject ball;
    public GameObject platform1;
    public GameObject platform2;
    public GameObject platform3;
    public GameObject obs1;
    public GameObject obs2;
    public GameObject obs3;
    public GameObject spawn;
    public GameObject death;
    public GameObject lever;

    public GameObject[] rotators;
    public GameObject[] obstacles;

    private float position;
    private Vector3 spawnPoint;
    private float killPoint;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = spawn.transform.position;
        killPoint = death.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        BallRespawn();
        MovePlatforms();
    }

    // public void MovePlatforms() {
    //     platform1.transform.Rotate(Vector3.forward * angle);
    //     platform2.transform.Rotate(Vector3.forward * angle);
    //     platform3.transform.Rotate(Vector3.forward * angle);
    //     angle *= -1;
    // }

    private void LeverPosition() {
        position = lever.transform.position.x;
    }

    public void MovePlatforms () {
        LeverPosition();

        Vector3 angleRotation = new Vector3(0f, 0f, -position*50f);
        Vector3 verticalPosition = new Vector3(0f, position, 0f);

        platform1.transform.eulerAngles = angleRotation;
        platform2.transform.eulerAngles = angleRotation;
        platform3.transform.eulerAngles = angleRotation;
        obs1.transform.localPosition = verticalPosition * 0.3f;
        obs2.transform.localPosition = verticalPosition * -0.25f;
        obs3.transform.localPosition = verticalPosition * 0.5f;
    }

    // private void VerticalMove(GameObject thing, float offset) {
    //     float x = thing.transform.position.x;
    //     float y = thing.transform.position.y;
    //     float z = thing.transform.position.z;
    //     thing.transform.position = new Vector3(x, obstacle1Origin+offset, z);
    // }

    public void BallRespawn() {
       if (ball.transform.position.y <= killPoint)
        ball.transform.position = spawnPoint;
    }

    public void NextLevel() {
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
