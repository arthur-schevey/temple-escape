using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPuzzleGoalScript : MonoBehaviour
{
    public GameObject ball;
    public GameObject exitDoor;
    public GameObject exitButton;

    // Start is called before the first frame update
    void Start()
    {
        exitButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider goal)
    {
        if(goal.gameObject.CompareTag("PuzzleBall"))
        {
            ball.SetActive(false);
            exitDoor.SetActive(false);
            exitButton.SetActive(true);
        }
    }
}
