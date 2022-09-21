using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistroyOutOfBounds : MonoBehaviour
{
    private float topBoundery = 30.0f;
    private float lowerBoundery = -30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBoundery)
        {
            Destroy(gameObject);
        }
      else if (transform.position.z<lowerBoundery)
                {
            Debug.Log("GAME OVER");
            Destroy(gameObject);
        }

    }
}
