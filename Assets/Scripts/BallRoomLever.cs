using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRoomLever : MonoBehaviour
{
    public GameObject lever;
    public GameObject boundLeft;
    public GameObject boundRight;
    private Vector3 left;
    private Vector3 right;
    // Start is called before the first frame update
    void Start()
    {
        left = boundLeft.transform.position;
        right = boundRight.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        BoundsCheck();
    }

    public void BoundsCheck() {
        if (lever.transform.position.x < left.x) {
            lever.transform.position = left;
        } else if (lever.transform.position.x > right.x) {
            lever.transform.position = right;
        }
    }
}
