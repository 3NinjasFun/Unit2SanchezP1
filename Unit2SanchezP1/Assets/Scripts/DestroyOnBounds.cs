using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnBounds : MonoBehaviour
{
    float topBound = 30;
    float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < lowerBound)
        {
            Debug.Log("GAME OVER!!");
            Destroy(gameObject);
        }
    }
}
