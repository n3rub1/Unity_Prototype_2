using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalInput;
    public float playerSpeed = 10f;
    public float xRange = 11.0f;

    public GameObject appleProjectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }


        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * playerSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //launch projectile from the player
            Instantiate(appleProjectilePrefab, transform.position, appleProjectilePrefab.transform.rotation);
        }


    }
}
