using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    GameObject playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("addScore"))
        {
            Destroy(collision.gameObject);
            playerController.GetComponent<PlayerController>().score++;
            playerController.GetComponent<PlayerController>().scoreText.text = 
            playerController.GetComponent<PlayerController>().score.ToString();
           // print(playerController.GetComponent<PlayerController>().score++);
        
        }
    }
}
