using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange= 10.0f;
    public GameObject projrctilePrefab;
    public TMP_Text scoreText;
    public int score;
    public GameObject star1;
    public GameObject star2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < (-xRange))
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }
        if (transform.position.x > (xRange))
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projrctilePrefab, transform.position, projrctilePrefab. transform.rotation);
        }
        if (score == 3)
        {
            star1.SetActive(true);
        }
        if (score == 8)
        {
            star2.SetActive(true);

        }

    }
}
