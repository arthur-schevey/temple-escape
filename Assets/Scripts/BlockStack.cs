using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockStack : MonoBehaviour
{

    public GameObject objectToEnable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("StackingBlock"))
        {
            Debug.Log("Blocks are stacked");
            Collider[] colliders = GetComponents<Collider>();

            if (colliders.Length == 3)
            {
                objectToEnable.SetActive(true);
            }   else    {
                objectToEnable.SetActive(false);
            }
        }
    }
}
